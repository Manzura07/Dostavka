class Program
{
    static void Main(string[] args) // --> parametr qatorlar massivida foydalaniladi.
    {
        Dictionary<string, decimal> dishes = new Dictionary<string, decimal>
{
    { "Pasta", 12900m }, // --> decimal, double turida tanliq qilinadi.
    { "Pizza", 9900m },
    { "Salat", 7900m },
    { "Muzqaymoq", 5900m }
};

        Dictionary<string, decimal> drinks = new Dictionary<string, decimal>
{
    { "Kofe", 2900m },
    { "Choy", 2900m },
    { "Suv", 9900m },
    { "Pepsi", 6900m },
    { "Coca - Cola", 10000m }
};


        string promoCode = "DISCOUNT10";
        decimal discount = 0.10m;

        decimal total = 0.0m;
        bool running = true;


        Console.WriteLine("\nRestoranimizga xush kelibsiz!");

        while (running)
        {
            string otvet;
            Console.WriteLine("Iltimos, ro'yxatdan o'ting. Ismingizni kiriting:");
            string name = Console.ReadLine()!;

            Console.WriteLine("Iltimos, familiyangizni kiriting:");
            string familiya = Console.ReadLine()!;

            Console.WriteLine("Iltimos, telefon raqamingizni kiriting:");
            string telefonRaqam = Console.ReadLine()!;

            Console.WriteLine("Iltimos, manzilingizni kiriting:");
            string manzil = Console.ReadLine()!;
            Console.WriteLine("Siz hammasini to'g'ri yozdingizmi? Qayta tekshirasizmi? (Ha/Yo'q)");
            otvet = Console.ReadLine()!.Trim().ToLower();
            while (otvet == "ha") ;

            Console.WriteLine($"Xush kelibsiz, {name} {familiya}!");

            while (true)
            {
                Console.WriteLine("\n===== Menyu =====");
                Console.WriteLine("1. Taomlar");
                Console.WriteLine("2. Ichimliklar");
                Console.WriteLine("3. Buyurtmani ko'rish");
                Console.WriteLine("4. Promokod kiritish");
                Console.WriteLine("5. Buyurtmani tugatish");
                Console.WriteLine("6. Chiqish");
                Console.WriteLine("Variantni tanlang:");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nTaomlar:");
                        foreach (var dish in dishes)
                        {
                            Console.WriteLine($"{dish.Key}: {dish.Value} sum");
                        }
                        Console.WriteLine("Buyurtma uchun taom nomini kiriting:");
                        string dishChoice = Console.ReadLine()!;
                        if (dishes.ContainsKey(dishChoice))// containsKey --> dictionary<Tkey, Tvalue> tarkibida korsatadigan kalit yoki yo'qligin tekshiradi.
                        {
                            total += dishes[dishChoice];
                            Console.WriteLine($"{dishChoice} buyurtmaga qo'shildi. Umumiy summa: {total} sum");
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri taom tanlovi.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nIchimliklar:");
                        foreach (var drink in drinks)
                        {
                            Console.WriteLine($"{drink.Key}: {drink.Value} sum");
                        }
                        Console.WriteLine("Buyurtma uchun ichimlik nomini kiriting:");
                        string drinkChoice = Console.ReadLine()!;
                        if (drinks.ContainsKey(drinkChoice))
                        {
                            total += drinks[drinkChoice];
                            Console.WriteLine($"{drinkChoice} buyurtmaga qo'shildi. Umumiy summa: {total} sum");
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri ichimlik tanlovi.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Sizning buyurtmangizning umumiy summasi: {total} sum");
                        break;

                    case "4":
                        Console.WriteLine("Promokodni kiriting:");
                        string enteredCode = Console.ReadLine()!;
                        if (enteredCode == promoCode)
                        {
                            total -= total * discount;
                            Console.WriteLine($"Promokod qo'llanildi. Yangi summa: {total} sum");
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri promokod.");
                        }
                        break;
                    case "5":
                        Console.WriteLine($"Buyurtmangiz tugatildi. Umumiy summa: {total} sum");
                        total = 0.0m;
                        break;

                    case "6":
                        running = false;
                        Console.WriteLine("Xizmatimizdan foydalanganingiz uchun rahmat. Xayr!");
                        break;

                    default:
                        Console.WriteLine("Noto'g'ri tanlov. Iltimos, qaytadan urinib ko'ring.");
                        break;
                }

                if (!running) break; // --> yoki false yoki true ekanligini ko'rsatadi.
            }
        }
    }
}

