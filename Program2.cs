using System;

// 電話資料類別
class PhoneList
{
    public string HomePhone;
    public string BusinessPhone;
    public string CellPhone;
}

// 名片資料類別
class Cards
{
    public string Name;
    public string Occupation;
    public int Age;
    public string Email;
    public PhoneList Phone;  // 成員變數是 PhoneList 類別

    // 顯示名片資訊
    public void GetCard()
    {
        Console.WriteLine($"姓名：{Name}");
        Console.WriteLine($"職業：{Occupation}");
        Console.WriteLine($"年齡：{Age}");
        Console.WriteLine($"Email：{Email}");
        Console.WriteLine($"住家電話：{Phone.HomePhone}");
        Console.WriteLine($"公司電話：{Phone.BusinessPhone}");
        Console.WriteLine($"手機：{Phone.CellPhone}");
    }
}

// 測試
class Program
{
    static void Main()
    {
        PhoneList phone = new PhoneList
        {
            HomePhone = "02-6969696",
            BusinessPhone = "02-9696969",
            CellPhone = "0912-777777"
        };

        Cards card = new Cards
        {
            Name = "帥哥",
            Occupation = "老師",
            Age = 30,
            Email = "ming@example.com",
            Phone = phone
        };

        card.GetCard();
    }
}