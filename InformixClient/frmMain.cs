using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.Informix;
using InformixClient.Model;

namespace InformixClient
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			setupListResult();
		}

		IfxConnection conn;
		DBManager dbm = new DBManager();

		private void itemConnect_Click(object sender, EventArgs e)
		{
			conn = dbm.connect();

			if (conn.State == ConnectionState.Open)
			{
				this.Text += " есть контакт!";
				itemConnect.Enabled = false;
				try
				{
					fillList();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		//------------------------
		// настройка списка для файлов
		//------------------------   
		private void setupListResult()
		{
			lstvPhones.Columns.Add("Ид");
			lstvPhones.Columns.Add("Телефон");
			lstvPhones.Columns.Add("Ф.И.О.");
			lstvPhones.Columns.Add("Улица");
			lstvPhones.Columns.Add("Дом");
			lstvPhones.Columns.Add("Квартира");
			lstvPhones.GridLines = true;
			lstvPhones.FullRowSelect = true;
			lstvPhones.MultiSelect = false;
			//lstvPhones.SmallImageList = imageList_small;
			//lstvPhones.LargeImageList = imageList_small;

			lstvPhones.View = View.Details;
			lstvPhones.Columns[0].Width = 30;
			lstvPhones.Columns[1].Width = 100;
			lstvPhones.Columns[2].Width = 200;
			lstvPhones.Columns[3].Width = 150;
			lstvPhones.Columns[4].Width = 50;
			lstvPhones.Columns[5].Width = 60;
		}

		//------------------------
		// загружаем файлы в список
		//------------------------   
		public void fillList()
		{
			List<Phone> phones = dbm.getAllPhones();
			lstvPhones.Items.Clear();

			foreach (Phone phone in phones)
			{
				ListViewItem items = new ListViewItem(phone.id.ToString());
				items.ImageIndex = 0;
				items.SubItems.Add(phone.phone);
				items.SubItems.Add(phone.person);
				items.SubItems.Add(phone.street);
				items.SubItems.Add(phone.building);
				items.SubItems.Add(phone.appartment);
				lstvPhones.Items.Add(items);
			}
		}

		private void itemExit_Click(object sender, EventArgs e)
		{
			conn.Close();
			Application.Exit();
		}

		private void itemAdd_Click(object sender, EventArgs e)
		{
			frmAdd fAdd = new frmAdd();
			fAdd.Owner = this;
			fAdd.openForm(conn);
		}

		private void lstvPhones_DoubleClick(object sender, EventArgs e)
		{
			if (lstvPhones.SelectedItems.Count != 0)
			{
				int id = Convert.ToInt32(lstvPhones.SelectedItems[0].SubItems[0].Text);
				string phone = lstvPhones.SelectedItems[0].SubItems[1].Text;
				string person = lstvPhones.SelectedItems[0].SubItems[2].Text;
				string street = lstvPhones.SelectedItems[0].SubItems[3].Text;
				string building = lstvPhones.SelectedItems[0].SubItems[4].Text;
				string appartment = lstvPhones.SelectedItems[0].SubItems[5].Text;
				frmAdd fAdd = new frmAdd();
				fAdd.Owner = this;
				fAdd.openForm(conn, id, phone, person, street, building, appartment);
			}
		}

		private void toolDelete_Click(object sender, EventArgs e)
		{
			if (lstvPhones.SelectedItems.Count != 0)
			{
				if (MessageBox.Show(this, "Вы действительно хотите удалить запись?", "Удаление записи...",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
				{					
					int id = Convert.ToInt32(lstvPhones.SelectedItems[0].SubItems[0].Text);
					if (dbm.deletePhone(id))
					{
						fillList();
					}					
				}
			}
		}
	}
}
