using ConsoleApp2;

Console.WriteLine("===== Clothing Shop =====");
Console.WriteLine("1. Buy Clothes");
Console.WriteLine("2. Sell Clothes");

Console.Write("Enter your option (1 or 2): ");
string option = Console.ReadLine();

switch (option)
{
    case "1":
        Console.WriteLine("\n--- Buy Clothes ---");

        Console.Write("Enter clothes number: ");
        string no = Console.ReadLine();

        Console.Write("Enter clothes category: ");
        string category = Console.ReadLine();

        Console.Write("Enter clothes brand: ");
        string brand = Console.ReadLine();

        Console.Write("Enter clothes size: ");
        string size = Console.ReadLine();

        Console.Write("Enter clothes color: ");
        string color = Console.ReadLine();

        Console.Write("Enter clothes price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        BuyService buyService = new BuyService();

        buyService.AddClothes(
            category, brand, size, color, price, 1
        );

        buyService.ShowClothes();
        break;

    case "2":
        Console.WriteLine("\n--- Sell Clothes ---");

        Console.Write("Enter clothes number: ");
        string s_no = Console.ReadLine();

        Console.Write("Enter clothes category: ");
        string s_category = Console.ReadLine();

        Console.Write("Enter clothes brand: ");
        string s_brand = Console.ReadLine();

        Console.Write("Enter clothes size: ");
        string s_size = Console.ReadLine();

        Console.Write("Enter clothes color: ");
        string s_color = Console.ReadLine();

        Console.Write("Enter clothes price: ");
        decimal s_price = decimal.Parse(Console.ReadLine());

        SellService sellService = new SellService();

        sellService.AddClothes(
            s_no, s_category, s_brand,
            s_size, s_color, s_price
        );

        sellService.ShowClothes();
        break;

    default:
        Console.WriteLine("Invalid option. Please enter 1 or 2.");
        break;
}

Console.ReadLine();