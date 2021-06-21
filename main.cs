using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of the item");
    string itemName = Console.ReadLine();
    Console.WriteLine ("Enter the quantity");
    string quantity = Console.ReadLine();
    Console.WriteLine ("Enter the price");
    string unitPrice = Console.ReadLine();
    int x1 = Convert.ToInt32(quantity);
    double y1 = Convert.ToDouble(unitPrice);
    Console.WriteLine("Total price of "+(itemName)+ " = $" +(x1*y1));
    
  }
}