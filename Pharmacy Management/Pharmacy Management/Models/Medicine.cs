using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.Models
{
    public class Medicine
    {
        private int medicineId { get; set; }
        private string name { get; set; }
        private string price { get; set; }
        private int quantityinstock { get; set; }

        public int MedicineId
        {
            get { return medicineId; }
            set { medicineId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public int QuantityInStock
        {
            get { return quantityinstock; }
            set { quantityinstock = value; }
        }

        public Medicine(int medicineid, string name, string price, int quantityinstock)
        {
            MedicineId = medicineid;
            Name = name;
            Price = price;
            QuantityInStock = quantityinstock;

        }

    }
}
