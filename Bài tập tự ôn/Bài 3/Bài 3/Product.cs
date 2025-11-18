using System;
using System.Collections.Generic;
class Product
{
    private string Id;
    private string Name;
    private double Price;
    public Product(string id,string name ,double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public virtual void Display()
    {
        Console.WriteLine( "ID: " + Id);
        Console.WriteLine("Name: " +Name);
        Console.WriteLine("Price: " + Price);   
    }
}