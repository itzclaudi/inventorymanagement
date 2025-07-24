using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudice_Inguanzo_C968.model
{
    internal class Inventory
    {
        public static void PopulateLists()
        {   
            //populate Products
            Product testProd1 = new Product(1, "Product 1", (decimal)50.00, 50, 50, 20);
            Product testProd2 = new Product(2, "Product 2", (decimal)200.50, 60, 65, 30);
            Product testProd3 = new Product(3, "Product 3", (decimal)100.50, 100, 10000, 20);
            Product testProd4 = new Product(4, "Product 4", (decimal)140.00, 250, 2000, 30);

            Products.Add(testProd1);
            Products.Add(testProd2);
            Products.Add(testProd3);
            Products.Add(testProd4);

            ////populate Parts
            Part testPart1 = new Inhouse(1, "Part 1", (decimal)100.00, 20, 150, 20, 21);
            Part testPart2 = new Inhouse(2, "Part 2", (decimal)150.00, 25, 100, 20, 22);
            Part testPart3 = new Inhouse(3, "Part 3", (decimal)200.00, 25, 100, 20, 23);
            Part testPart4 = new Outsourced(4, "Part 4", (decimal)50.50, 20, 100, 20, "CompanyA");
            Part testPart5 = new Outsourced(5, "Part 5", (decimal)60.00, 58, 100, 20, "CompanyB");
            Part testPart6 = new Outsourced(6, "Part 6", (decimal)1100.00, 92, 100, 20, "CompanyB");

            AllParts.Add(testPart1);
            AllParts.Add(testPart2);
            AllParts.Add(testPart3);
            AllParts.Add(testPart4);
            AllParts.Add(testPart5);
            AllParts.Add(testPart6);

            ////Add Parts to Products

            testProd1.AddAssociatedPart(testPart1);
            testProd1.AddAssociatedPart(testPart2);
            testProd2.AddAssociatedPart(testPart3);
            testProd2.AddAssociatedPart(testPart4);
            testProd3.AddAssociatedPart(testPart5);
            testProd3.AddAssociatedPart(testPart6);

        }

        static public BindingList<Product> Products = new BindingList<Product>();
        static public BindingList<Part> AllParts = new BindingList<Part>();


        // Products Methods
            public static void AddProduct(Product product)
                {
                    Products.Add(product);
                }

            public static bool RemoveProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product LookupProduct(int productID)
            {
                foreach (Product product in Products)
                {
                    if (product.ProductID == productID)
                {
                        return product;
                    }
                }
                return null;
            }

            public static void UpdateProduct(int productID, Product updatedProduct)
            {
                foreach (Product CurrentProduct in Products)
                {
                    if (CurrentProduct.ProductID == productID)
                    {
                    CurrentProduct.Name = updatedProduct.Name;
                    CurrentProduct.InStock = updatedProduct.InStock;
                    CurrentProduct.Price = updatedProduct.Price;
                    CurrentProduct.Max = updatedProduct.Max;
                    CurrentProduct.Min = updatedProduct.Min;
                    CurrentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                        return;
                    }
                }

            }
            public static void AddPart(Part part)
            {
                AllParts.Add(part);

            }

            public static bool DeletePart(Part part)
            {
                try
                {
                    AllParts.Remove(part);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static Part LookupPart(int partID)
            {
                foreach (Part part in AllParts)
                {
                    if (part.PartID == partID)
                    {
                        return part;
                    }
                }
                return null;
            }

            public static void UpdatePart(int partID, Part updatedPart)
            {
                foreach (Part CurrentPart in AllParts)
                {
                    if (CurrentPart.PartID == partID)
                    {
                        CurrentPart.Name = updatedPart.Name;
                        CurrentPart.InStock = updatedPart.InStock;
                        CurrentPart.Price = updatedPart.Price;
                        CurrentPart.Min = updatedPart.Min;
                        CurrentPart.Max = updatedPart.Max;
                        return;
                    }
                }

            }
    }
}