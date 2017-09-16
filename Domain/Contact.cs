using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Contact
	{
		private static int _id;

		public int ContactId { get; private set; }

		public Contact()
		{
			_id++;
			ContactId = _id;
		}

		public string ContactValue { get; set; }

		public ContactType ContactType { get; set; }

		public Person Person { get; set; }
	}
}
