using System;

namespace SimpleClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }

        public int ShelfLifeInDays { get; set; }

        public Product() { }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight, int shelfLifeInDays)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
            ShelfLifeInDays = shelfLifeInDays;
        }

        //введення терміну придатності
        public void InputShelfLife()
        {
            Console.WriteLine("Оберіть одиниці вимірювання терміну придатності:");
            Console.WriteLine("1 - Дні\n2 - Місяці\n3 - Роки");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Введіть значення: ");
            int value = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: ShelfLifeInDays = value; break;
                case 2: ShelfLifeInDays = value * 30; break;
                case 3: ShelfLifeInDays = value * 365; break;
                default: Console.WriteLine("Неправильний вибір."); break;
            }
        }

        //виведення терміну придатності
        public void DisplayShelfLife()
        {
            Console.WriteLine($"Термін придатності:");
            Console.WriteLine($"У днях: {ShelfLifeInDays}");
            Console.WriteLine($"У місяцях: {ShelfLifeInDays / 30.0:F2}");
            Console.WriteLine($"У роках: {ShelfLifeInDays / 365.0:F2}");
        }
    }
}
namespace SimpleClassLibrary
{
    public class Currency
    {
        public string Name { get; set; }
        public double ExRate { get; set; }

        public Currency() { }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
    }
}
