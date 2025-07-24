using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudice_Inguanzo_C968.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(int productID, string name, decimal price, int inStock, int max, int min)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            Part part = LookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}