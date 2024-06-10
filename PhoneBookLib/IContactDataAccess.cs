using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookLib
{
    public interface IContactDataAccess
    {
        List<Contact> GetContacts();
        Contact GetContactById(int id);
        void AddContact(Contact con);
        void DeleteContact(int id);
        void UpdateContacts(Contact con);
    }
}
