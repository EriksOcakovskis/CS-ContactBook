using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public class ContactType
  {

    private static int _id;

    public int ContactTypeId { get; private set; }

    public ContactType()
    {
      _id++;
      ContactTypeId = _id;
    }

    public string ContactTypeName { get; set; }

    public List<Contact> Contacts { get; set; } = new List<Contact>();
  }
}
