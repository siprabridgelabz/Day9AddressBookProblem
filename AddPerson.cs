﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddPerson
    {
        public void details()
        {
            List<contact> list = new List<contact>();

            {
                contact address = new contact();
                Console.Write("Enter firstName: ");
                address.firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone umber: ");
                address.phoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter zip: ");
                address.zip = Convert.ToInt32(Console.ReadLine());
                list.Add(address);
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.eMail);

                ///Edit by name///

                Console.WriteLine("Edit by using First Name: ");
                String name = Console.ReadLine();
                foreach (var data in list)
                {
                    if (data.firstName == name)
                    {
                        // Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter first name ");
                                data.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter last name ");
                                data.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter address");
                                data.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter city");
                                data.city = Console.ReadLine();
                                break;
                            case 5:
                                address.state = Console.ReadLine();
                                Console.Write("Enter phone umber: ");
                                break;
                            case 6:
                                address.state = Console.ReadLine();
                                Console.WriteLine("Enter state");
                                break;
                            case 7:
                                address.phoneNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter phne number");
                                break;
                            case 8:
                                address.zip = Convert.ToInt32(Console.ReadLine());
                                list.Add(address);
                                break;
                            case 9:
                                Console.WriteLine("Enter email");
                                data.eMail = Console.ReadLine();
                                break;
                        }
                        Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.zip + "\n" + address.eMail);

                    }

                }

            }
        }

        public void deleteContact()
        {
            contact address = new contact();
            Console.WriteLine("Enter name to delete details");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstname.Equals(name))
                    address = data;

            }
            list.Remove(address);
            Console.WriteLine("contact was deleted" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.zip + "\n" + address.eMail);

        }

    }

}

