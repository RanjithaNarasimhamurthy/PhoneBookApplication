using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookLib
{
    public class ContactDataAccessLayer:IContactDataAccess
    {
        private readonly ContactDbContext _dbCtx;
        public ContactDataAccessLayer(ContactDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }
        public void AddContact(Contact con)
        {
            _dbCtx.Contacts.Add(con);
            _dbCtx.SaveChanges();
        }
        public void DeleteContact(int Id)
        {
            var record = _dbCtx.Contacts.Find(Id);
            if (record != null)
            {
                _dbCtx.Contacts.Remove(record);
                _dbCtx.SaveChanges();
            }
        }
        public Contact GetContactById(int Id)
        {
            var record = _dbCtx.Contacts.Find(Id);
            return record;
        }
        public List<Contact> GetContacts()
        {
            var records = _dbCtx.Contacts.ToList();
            return records;
        }
        public void UpdateContacts(Contact con)
        {
            var record = _dbCtx.Contacts.Find(con.Id);
            if (record != null)
            {
                record.Id = con.Id;
                record.FirstName = con.FirstName;
                record.LastName = con.LastName;
                record.Gender = con.Gender;
                record.Phone = con.Phone;
                record.Email = con.Email;
                record.Dob = con.Dob;
                record.City = con.City;
                record.Country = con.Country;
                record.State = con.State;
                record.Picture = con.Picture;
                _dbCtx.SaveChanges();
            }
        }
    }
}
