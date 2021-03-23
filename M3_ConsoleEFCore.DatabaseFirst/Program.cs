using M3_ConsoleEFCore.DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M3_ConsoleEFCore.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new SalesContext();

            var supplier1 = new Supplier()
            {
                CompanyName = "QBO Institute 1",
                ContactName = "Luis Chang",
                ContactTitle = "Sales Manager",
                City = "Lima",
                Country = "Perú",
                Phone = "998873637",
                Fax = "22121122"
            };

            //Add Supplier
            //context.Supplier.Add(supplier1);
            //context.SaveChanges();

            var supplier2 = new Supplier()
            {
                CompanyName = "QBO Institute 2",
                ContactName = "Luis Chang",
                ContactTitle = "Sales Manager",
                City = "Lima",
                Country = "Perú",
                Phone = "998873637",
                Fax = "22121122"
            };
            var supplier3 = new Supplier()
            {
                CompanyName = "QBO Institute 3",
                ContactName = "Luis Chang",
                ContactTitle = "Sales Manager",
                City = "Lima",
                Country = "Perú",
                Phone = "998873637",
                Fax = "22121122"
            };

            //Add Range
            //var supplierList = new List<Supplier>();
            //supplierList.Add(supplier2);
            //supplierList.Add(supplier3);

            //context.Supplier.AddRange(supplierList);
            //context.SaveChanges();

            //Remove Supplier
            //-->Query by LINQ

            //var searchSupplier = (from sup in context.Supplier
            //                      where sup.Id == 32
            //                      select sup).FirstOrDefault();

            //context.Supplier.Remove(searchSupplier);
            //context.SaveChanges();

            //Query By Lambda Expressions

            //var searchSupplier = context.Supplier.Include("Product").Where(x => x.Id == 1).FirstOrDefault();
            //var products = context.Product.Where(p => p.SupplierId == 1).ToList();
            //context.Supplier.Remove(searchSupplier);
            //context.SaveChanges();

            //Console.WriteLine("CompanyName:" + searchSupplier.CompanyName
            //                 + " ContactName" + searchSupplier.ContactName);

            //foreach (var item in searchSupplier.Product)
            //{
            //    Console.WriteLine("ProductName:" + item.ProductName
            //                + " UnitPrice" + item.UnitPrice);
            //}

            //Update
            //var searchUpdate = context.Supplier.Where(x => x.Id == 31).FirstOrDefault();
            //searchUpdate.ContactTitle = "Administrator";
            //context.SaveChanges();

            //Joins

            var result = from p in context.Product
                         join s in context.Supplier
                         on p.SupplierId equals s.Id
                         where p.UnitPrice >= 25 && p.UnitPrice <= 30
                         select new
                         {
                             p.ProductName,
                             p.UnitPrice,
                             s.CompanyName
                         };

            Console.WriteLine("******JOINS*******");
            foreach (var item in result)
            {
                Console.WriteLine("CompanyName: "+ item.CompanyName +
                                  "ProductName: " + item.ProductName +
                                  "UnitPrice: "+ item.UnitPrice);
            }

            var userList = context.Users.ToList();

            foreach (var item in userList)
            {
                Console.WriteLine("Id: " + item.Id +
                                 "Username: " + item.Username);
            }


            Console.ReadKey();
        }
    }
}
