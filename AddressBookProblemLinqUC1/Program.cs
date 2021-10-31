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
                 new AddressBook{Name="Akshay",Contact=9259864289,City="Pune",State="Maharashtra",Pin=413101},
                 new AddressBook{Name="Devansh",Contact=9959868899,City="Pune",State="Maharashtra",Pin=412101},
            };
           foreach(var list in address)
            {
            Console.WriteLine("Name:-"+list.Name+" "+"Contact:-"+list.Contact+" "+"City:-"+list.City+" "+"State:-"+list.State+" "+"Pin Code:-"+list.Pin);
            }
        }
    }
}
