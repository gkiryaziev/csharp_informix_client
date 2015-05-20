using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformixClient.Model
{
	public class Phone
	{
		public int id { get; set; }
		public string phone { get; set; }
		public string person { get; set; }
		public string street { get; set; }
		public string building { get; set; }
		public string appartment { get; set; }
	}
}
