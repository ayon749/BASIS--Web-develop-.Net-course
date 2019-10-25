using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOnetoOneApp.Models
{
	class Address
	{
		public Address()
		{
		}

		public Address(string houseNumber, string roadNumber, string ward, int postalCode, string district):this()
		{
			HouseNumber = houseNumber;
			RoadNumber = roadNumber;
			Ward = ward;
			PostalCode = postalCode;
			District = district;
		}

		public string HouseNumber { set; get; }
		public string RoadNumber { set; get; }
		public string Ward { set; get; }
		public int PostalCode { set; get; }
		public string District { set; get; }
	}
}
