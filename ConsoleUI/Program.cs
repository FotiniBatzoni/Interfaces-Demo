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
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var prod in cart)
            {
                prod.ShipItem(customer);

                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
                }
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

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Footbal" });
            output.Add(new PhysicalProductModel { Title = "T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Course" });

            return output;
        }
    }
}
