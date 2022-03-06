using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAddressbook
{
    internal class FullAddress
    {
        public static Dictionary<string, List<ContactFull>> mySystem = new Dictionary<string, List<ContactFull>>();
        
        public static void UpdateContact()
        {
            Console.WriteLine("Enter the first name of the person whoom you want to edit the details");
            string addressBookName = Console.ReadLine();
            string editKey = Console.ReadLine();
            int flag = 0;
            if (mySystem[addressBookName].Count > 0)
            {
                foreach (ContactFull contact in mySystem[addressBookName])
                {
                    if (editKey.ToLower() == contact.firstName.ToLower())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the key number for editing the details\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID\n 9. Exit editor");
                            int key = Convert.ToInt32(Console.ReadLine());
                            switch (key)
                            {
                                case 1:
                                    Console.WriteLine("Enter the new First name");
                                    contact.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the new Last name");
                                    contact.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the new address");
                                    contact.address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the new city");
                                    contact.city = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the new state");
                                    contact.state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the new zip code");
                                    contact.ZipCode = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the new phone");
                                    contact.PhoneNunmber = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the new E-Mail ID");
                                    contact.eMail = Console.ReadLine();
                                    break;
                                case 9:
                                    flag = 1;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid input");
                                    UpdateContact();
                                    break;
                            }
                            if (flag == 1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine("{0}'s contact has been sucessfully added", editKey);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
            if (flag == 0)
            {

                Console.WriteLine("contact of the person {0} does not exist", editKey);
            }
        }

    }
}
