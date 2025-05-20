using System;

namespace VehicleApp
{
    // 定義 IPrice 介面
    public interface IPrice
    {
        double GetPrice();
    }

    // 定義 Car 類別，實作 IPrice 介面
    public class Car : IPrice
    {
        // 屬性：車名和價格
        public string Name { get; set; }
        public double Price { get; set; }

        // 建構子
        public Car(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // 實作介面的 GetPrice 方法
        public double GetPrice()
        {
            return Price;
        }

        // 額外的方法：取得車名
        public string GetName()
        {
            return Name;
        }
    }

    // 主程式
    class Program
    {
        static void Main(string[] args)
        {
            // 建立 Car 物件
            Car car1 = new Car("Toyota Corolla", 750000);
            Car car2 = new Car("Tesla Model 3", 1600000);

            // 顯示車輛資訊
            Console.WriteLine($"車名: {car1.GetName()}, 價格: {car1.GetPrice():C}");
            Console.WriteLine($"車名: {car2.GetName()}, 價格: {car2.GetPrice():C}");
        }
    }
}