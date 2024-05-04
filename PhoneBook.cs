using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class PhoneBook
    {
        private List<Contact> _contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.Where(c => c.Number.Equals(number)).ToList();

            foreach (var item in contact)
            {
                Console.WriteLine($"{item.Name} , {item.Number}\n");
            }
            if (contact != null) { Console.WriteLine("Contact is not on record\n\n\n\n\n"); }
        }

        public void DisplayAllContacts()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"{contact.Name}, {contact.Number}\n");

            }

        }

        public void SearchContact(string name)
        {
            var contact = _contacts.SingleOrDefault(x => x.Name.Contains(name));
            if (contact != null)
            {
                Console.WriteLine($"{contact.Name}, {contact.Number}\n");
            }
            else
                Console.WriteLine("contact not in record\n");
        }

        public void DeleteAContact(string name)
        {
            var contact = _contacts.SingleOrDefault(c => c.Name.Contains(name));
            _contacts.Remove(contact);

            if (contact != null)
            {
                Console.WriteLine("Contact successfully deleted\n\n\n\n\n\n\n ");

            }else
                Console.WriteLine("Contact not on record\n\n\n\n\n\n\n");
        }

    }
}

