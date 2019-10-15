using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
	class Person
	{
		private string firstName, middleName, lastName;
		private int id;
		
		public Person(string firstName,string middleName,string lastName):this()
		{
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
		}
		public Person()
		{
			id = 123;
		}
		public int GetId()
		{
			return id;

		}

		public string GetFullName()

		{
			string fullName = firstName + " " + middleName + " " + lastName;
			return fullName;
		}

	}
}
