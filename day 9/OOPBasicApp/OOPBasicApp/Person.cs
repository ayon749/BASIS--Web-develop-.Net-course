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
		
		public Person(string firstName,string middleName,string lastName):this(firstName,lastName)
		{
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
		}
		public Person(string firstName,string lastName):this()
		{
			this.firstName = firstName;
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
			string fullName;
			if (middleName != string.Empty)
			{
				 fullName = firstName + " " + middleName + " " + lastName;
				
			}
			else
			{
				fullName = firstName + " " + lastName;
			}
			return fullName;
		}

	}
}
