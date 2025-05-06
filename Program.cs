using System;

class Box
{
    // 成員變數
    public double Width;
    public double Height;
    public double Length;

    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 計算表面積
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
}

// 測試
class Program
{
    static void Main()
    {
        Box box = new Box(3, 4, 5);
        Console.WriteLine("體積：" + box.Volume());
        Console.WriteLine("表面積：" + box.Area());
    }
}
