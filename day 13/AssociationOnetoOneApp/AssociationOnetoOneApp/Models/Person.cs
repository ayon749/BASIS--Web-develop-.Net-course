using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOnetoOneApp.Models
{
	class Person
	{
		public Person()
		{
		}

		public Person(string firstName, string middleName, string lastName):this()
		{
			FirstName = firstName;
			MiddleName = middleName;
			LastName = lastName;
		}

		public Person(string firstName, string middleName, string lastName, Address oneaddress) : this(firstName, middleName, lastName)
		{
			Oneaddress = oneaddress;
		}

		public string FirstName { set; get; }
		public string MiddleName { set; get; }
		public string LastName { set; get; }
		public Address Oneaddress { set; get; }
		public void Display()
		{
			Console.WriteLine("My name is " + FirstName + " " + MiddleName + " " + LastName);
			Console.WriteLine("My address is  " + Oneaddress.HouseNumber + " " + Oneaddress.RoadNumber + " " + Oneaddress.Ward + " " + Oneaddress.PostalCode + " " + Oneaddress.District);

		}
	}
}
