using ProductReviewManagementWithLinq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblemLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book problem statement");

            List<AddressBook> address = new List<AddressBook>()
            {
                 new AddressBook{Name="Akshay",Contact=9359864239,City="Pune",State="Maharashtra",Pin=412101},
                 new AddressBook{Name="Vinod",Contact=9359868837,City="Pune",State="Maharashtra",Pin=412102},
                 new AddressBook{Name="Neeta",Contact=9959864239,City="Abad",State="Maharashtra",Pin=412104},
                 new AddressBook{Name="Somesh",Contact=9759868837,City="Abad",State="Maharashtra",Pin=412105},
            };
            Book bk = new Book();
            bk.TopRecords(address);
        }
    }
}
