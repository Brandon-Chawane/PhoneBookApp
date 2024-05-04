using System.Threading.Channels;

namespace PhoneBookApp
{
    internal class Program
    {
        static string inPut;
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            Console.WriteLine("Welcome to World Union Bank");
            SelectionContent();
            inPut = Console.ReadLine();

            while (true)
            {
                switch (inPut)
                {
                    case "1":

                        Console.WriteLine("Enter name: \n");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter number: \n");
                        string number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":

                        Console.WriteLine("Enter number you want to Display:\n");
                        number = Console.ReadLine();
                        phoneBook.DisplayContact(number);

                        break;


                    case "3":
                        Console.WriteLine("Enter name of contact you want to search:\n ");
                        name = Console.ReadLine();
                        phoneBook.SearchContact(name);
                        break;


                    case "4":
                        Console.WriteLine();
                        phoneBook.DisplayAllContacts();
                        break;

                    case "5":
                        Console.WriteLine("Enter a name you would like to delete:\n");
                        name = Console.ReadLine();
                        phoneBook.DeleteAContact(name);
                        break;

                    case "6":

                        return;

                    default:
                        Console.WriteLine("Invalid selection\n");

                        break;
                }
                SelectionContent();
                inPut = Console.ReadLine();
            }
        }

        public static void SelectionContent()
        {
            Console.WriteLine("Choose your selection\n ");
            Console.WriteLine("1 - Add Contact\n2 - Enter Contact number you want to Display\n3 - Search contact name\n4 - Display All Contacts\n5 - Delete a contact\n6 - Exit\n");

        }
    }
}
