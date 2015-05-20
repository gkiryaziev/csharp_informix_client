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

namespace InformixClient
{
	public partial class frmAdd : Form
	{
		public frmAdd()
		{
			InitializeComponent();
		}

		IfxConnection conn;
		bool isAdd = true;

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (isAdd)
			{
				add();
			}
			else
			{
				update();
			}
		}

		private void update()
		{
			int id = Convert.ToInt32(txtId.Text);
			string phone = txtPhone.Text;
			string person = txtPerson.Text;
			string street = txtStreet.Text;
			string building = txtBuilding.Text;
			string appartment = txtAppartment.Text;

			// save new user
			IfxCommand cmd = new IfxCommand();
			string cmdString = string.Format("update phonebook set phone = '{0}', person = '{1}', street = '{2}', building = '{3}', appartment = '{4}' where id = {5}",
				phone, person, street, building, appartment, id);

			cmd.Connection = conn;
			cmd.CommandText = cmdString;

			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			frmMain fMain = (frmMain)this.Owner;
			fMain.fillList();
			this.Close();
		}

		private void add()
		{
			string phone = txtPhone.Text;
			string person = txtPerson.Text;
			string street = txtStreet.Text;
			string building = txtBuilding.Text;
			string appartment = txtAppartment.Text;

			// save new user
			IfxCommand cmd = new IfxCommand();
			string cmdString = string.Format("insert into phonebook(phone, person, street, building, appartment) values('{0}', '{1}', '{2}', '{3}', '{4}')",
				phone, person, street, building, appartment);

			cmd.Connection = conn;
			cmd.CommandText = cmdString;

			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			frmMain fMain = (frmMain)this.Owner;
			fMain.fillList();
			this.Close();
		}

		public void openForm(IfxConnection c)
		{
			isAdd = true;	// insert
			conn = c;
			this.ShowDialog();
		}

		public void openForm(IfxConnection c, int id, string phone, string person, string street, string building, string appartment)
		{
			isAdd = false;	// update
			conn = c;

			txtId.Text = id.ToString();
			txtPhone.Text = phone;
			txtPerson.Text = person;
			txtStreet.Text = street;
			txtBuilding.Text = building;
			txtAppartment.Text = appartment;

			this.ShowDialog();
		}
	}
}
