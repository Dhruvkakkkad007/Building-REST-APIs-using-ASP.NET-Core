//5.Write a program to manage a supermarket inventory.
//Create an Item class with Item_Code, Item_Name, and Stock_Quantity.
//Use a constructor to initialize the objects and an array of objects to store and
//display the details of 10 different items


using System;


namespace Lab_3
{
    class Item
    {
        int item_Code;
        string item_Name;
        int Stock_Quantity;


        public Item(int item_Code, string item_Name, int Stock_Quantity)
        {
            this.item_Code = item_Code;
            this.item_Name = item_Name;
            this.Stock_Quantity = Stock_Quantity;
        }

        public void displayItemDetails()
        {
            Console.WriteLine($"Item Code: {item_Code}, Item Name: {item_Name}, Stock Quantity: {Stock_Quantity}");
        }
    }
}
