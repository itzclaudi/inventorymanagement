using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Claudice_Inguanzo_C968.model
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, decimal price, int inStock, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
