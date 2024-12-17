using System;
using SimpleClassLibrary;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть кількість товарів: ");
        int n = int.Parse(Console.ReadLine());
        Product[] products = new Product[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nВведіть дані для товару {i + 1}:");
            Console.Write("Назва: ");
            string name = Console.ReadLine();

            Console.Write("Ціна: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Назва валюти: ");
            string currencyName = Console.ReadLine();

            Console.Write("Курс валюти: ");
            double exRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Кількість: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Виробник: ");
            string producer = Console.ReadLine();

            Console.Write("Вага (кг): ");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(name, price, new Currency(currencyName, exRate), quantity, producer, weight, 0);
            product.InputShelfLife();

            products[i] = product;
        }

        Console.WriteLine("\nДані про товари:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
            product.DisplayShelfLife();
            Console.WriteLine("-----------------");
        }
    }
}

