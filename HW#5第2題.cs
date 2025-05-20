using System;

class MyMath
{
    // 過載的 Cube 方法：計算 int 的立方
    public static int Cube(int x)
    {
        return x * x * x;
    }

    // 過載的 Cube 方法：計算 double 的立方
    public static double Cube(double x)
    {
        return x * x * x;
    }

    // 過載的 MinElement 方法：找出三個 int 值中的最小值
    public static int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    // 過載的 MinElement 方法：找出四個 int 值中的最小值
    public static int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(Math.Min(a, b), Math.Min(c, d));
    }
}

class Program
{
    static void Main()
    {
        // 測試 Cube 方法
        Console.WriteLine("Cube(3) = " + MyMath.Cube(3));         // int
        Console.WriteLine("Cube(2.5) = " + MyMath.Cube(2.5));     // double

        // 測試 MinElement 方法
        Console.WriteLine("MinElement(5, 3, 8) = " + MyMath.MinElement(5, 3, 8));
        Console.WriteLine("MinElement(10, 2, 7, 4) = " + MyMath.MinElement(10, 2, 7, 4));
    }
}