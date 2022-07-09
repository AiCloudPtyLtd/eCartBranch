using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace eCart.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                  CategoryID = 1,
                    CategoryName = "Access"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "IoT"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Power"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Surveillance"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Telecom"
                },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Finger Print",
                    Description = "This is a convenient touch access system. It has options to be powered by a battery pack or alternative power source." +
                                  "A touch and go system!",
                    ImagePath="Access.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Key Pad",
                    Description = "There's nothing new about the old fashioned key pad system except that tis one is integrated into a modern solution." +
                                  "System generated code issuing.",
                    ImagePath="Access.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Remote",
                    Description = "Another vintage access device in hand. Individual programed and issued with a built in signal protection mechanism.",
                    ImagePath="Access.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Intercom",
                    Description = "A modern two way voice and video system. Fully integratable with all the access control products." +
                                  "Scalable for multi access solutions. ",
                    ImagePath="Access.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "RFID",
                    Description = "Effortless individually issued drive through system, no remotes or button pushing." +
                                  "No batteries required.",
                    ImagePath="Access.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Telemetry",
                    Description = "Range of machine management and monitoring maintained systems. ",
                    ImagePath="Privacy.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Switch",
                    Description = "Multi purpose cloud switching device with time schedule applications",
                    ImagePath="Privacy.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Desktops",
                    Description = "Domain managed virtual network systems, with security features such as remote wipe.",
                    ImagePath="Privacy.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Mobiles",
                    Description = "Personal managed virtual network systems, with security features such as remote wipe.",
                    ImagePath="Privacy.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Inverters",
                    Description = "Scalable power production systems for backup or off grid solutions.",
                    ImagePath="Index.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Batteries",
                    Description = "Scalable storage solutions with battery protection system.",
                    ImagePath="Index.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Panels",
                    Description = "Scalable solar panel solutions with optional sun tracking technology.",
                    ImagePath="Index.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Camaras",
                    Description = "Solar or alternative power source monitoring devices. For scalable wireless and LAN network systems." +
                                  "Optionally integratable with other IoT devices.",
                    ImagePath="Security.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Sensors",
                    Description = "Solar or alternative power source detection devices. For scalable wireless and LAN network systems." +
                                  "Optionally integratable with other IoT devices.",
                    ImagePath="Security.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Detection",
                    Description = "Solar or alternative power source object detection devices. For scalable wireless and LAN network systems." +
                                  "Optionally integratable with other IoT devices.",
                    ImagePath="Security.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "SDN",
                    Description = "Software Defined Networks. For scalable wireless and LAN network systems." +
                                  "Optionally integratable with other IoT devices.",
                    ImagePath="Telecoms.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };
            return products;
        }
    }
}