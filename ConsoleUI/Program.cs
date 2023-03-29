using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Barton",
                City = "NY",
                EmailAddress = "tim@testmail.com",
                PhoneNumber = "1234567890",
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Footbal" });
            output.Add(new PhysicalProductModel { Title = "T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });

            return output;
        }
    }
}
