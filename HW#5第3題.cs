using System;

class UnitConverter
{
    // 委派宣告：接收 double 傳回 double
    public delegate double ConvertDelegate(double value);

    // 將英碼轉換成英吋
    public static double YardsToInches(double yards)
    {
        return yards * 36; // 1 yard = 3 feet = 36 inches
    }

    // 將英尺轉換成英吋
    public static double FeetToInches(double feet)
    {
        return feet * 12; // 1 foot = 12 inches
    }
}

class Program
{
    static void Main()
    {
        Console.Write("請輸入數值：");
        double input = Convert.ToDouble(Console.ReadLine());

        Console.Write("請選擇轉換類型 (1: 英尺轉英吋, 2: 英碼轉英吋)：");
        string choice = Console.ReadLine();

        // 宣告委派
        UnitConverter.ConvertDelegate convertMethod;

        // 動態設定委派方法
        if (choice == "1")
        {
            convertMethod = new UnitConverter.ConvertDelegate(UnitConverter.FeetToInches);
        }
        else if (choice == "2")
        {
            convertMethod = new UnitConverter.ConvertDelegate(UnitConverter.YardsToInches);
        }
        else
        {
            Console.WriteLine("輸入錯誤！");
            return;
        }

        // 執行委派轉換
        double result = convertMethod(input);
        Console.WriteLine($"轉換結果為：{result} 英吋");
    }
}