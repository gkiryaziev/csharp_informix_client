using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.Informix;
using System.Windows.Forms;
using InformixClient.Model;


namespace InformixClient
{
	class DBManager
	{
		IfxConnection conn = new IfxConnection();

		public IfxConnection connect()
		{			
			string connectionString = "Database=phones;Host=192.168.2.111;Server=ol_srv;Service=9999;Protocol=onsoctcp;UID=informix;Password=admin;";
			try
			{
				conn.ConnectionString = connectionString;
				conn.Open();				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return conn;
		}

		public List<Phone> getAllPhones()
		{
			List<Phone> phones = new List<Phone>();
			IfxCommand cmd = new IfxCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select * from phonebook";
			IfxDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				phones.Add(new Phone()
				{
					id = dr.GetInt32(dr.GetOrdinal("id")),
					phone = dr.GetString(dr.GetOrdinal("phone")),
					person = dr.GetString(dr.GetOrdinal("person")),
					street = dr.GetString(dr.GetOrdinal("street")),
					building = dr.GetString(dr.GetOrdinal("building")),
					appartment = dr.GetString(dr.GetOrdinal("appartment"))
				});
			}

			dr.Close();
			return phones;
		}

		public bool deletePhone(int id)
		{
			IfxCommand cmd = new IfxCommand();
			cmd.Connection = conn;
			cmd.CommandText = string.Format("delete from phonebook where id = {0}", id);
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}
	}
}
