using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class Context
  {
		public List<Person> People { get; set; } = new List<Person>();

		public List<Contact> Contact { get; set; } = new List<Contact>();

		public List<ContactType> ContactType { get; set; } = new List<ContactType>();
	}
}
