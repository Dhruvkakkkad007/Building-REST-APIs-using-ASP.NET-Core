using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    interface IInventoryManager
    {
        void checkStock();
    }

    class GroceryStock : IInventoryManager
    {

       public void checkStock()
        {
            int stock = 10;
            if (stock < 0)
            {
                throw new Exception("Not Available");
            }

            Console.WriteLine("Stock Available");

        }
    }

    class ElectronicStock : IInventoryManager
    {
        public void checkStock()
        {
            string products = "";

            if (products == "")
            {
                throw new Exception("Incorrect Product Details");

            }

            Console.WriteLine("Stock Available");

        }
    }
}