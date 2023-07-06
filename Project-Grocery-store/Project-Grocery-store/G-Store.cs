using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Grocery_store
{
    class G_Store
    {

        private int productID;
        private string name;
        private string category;
        private double price;
        private int quanity;

        public G_Store(int productID, string name, string category, double price, int quanity)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Quanity = quanity;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }
        public int Quanity { get => quanity; set => quanity = value; }
    }
}
