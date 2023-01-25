using System;
using System.Collections.Generic;

class Product
{
    public string name;
    public double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
}

class ShoppingCart
{
    List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowCart()
    {
        double totalPrice = 0;
        Console.WriteLine("Lista produktów:");
        foreach (var product in products)
        {
            Console.WriteLine("- " + product.name + ", cena: " + product.price + "zł");
            totalPrice += product.price;
        }
        Console.WriteLine("Ilość produktów: " + products.Count);
        Console.WriteLine("Suma cen: " + totalPrice + "zł");
    }
}