using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{

    static void Main()
    {
        Console.WriteLine("Malika do'koni - elektron, Oziq-ovqat do'koni - oziq-ovqat, Restaurant - restoran, ToshQaychiQog'oz - game, Dorixona - apteka");
        string tanlanganProjectlar = Console.ReadLine();


        if (tanlanganProjectlar == "elektron")
        {
            // Elektron do'koniga oid kodlar
            Dictionary<string, int> tovarlar = new Dictionary<string, int>() {
                { "Telefon", 1000000 },
                { "Planshet", 2000000},
                { "Kompyuter", 5000000 },
                { "Monitor",  1500000 },
                { "Printer", 500000 },
                { "Smartwatch", 300000 }
            };

            Console.WriteLine("Assalomu alaykum! Malika Do'koniga xush kelibsiz.");
            Console.WriteLine("Bizning malika do'konimizda quyidagi gatgetlar mavjud:");

            foreach (KeyValuePair<string, int> mahsulot in tovarlar)
            {
                Console.WriteLine("{0}. {1} - {2} so'm", Array.IndexOf(tovarlar.ToArray(), mahsulot) + 1, mahsulot.Key, mahsulot.Value);
            }

            List<string> tanlanganMahsulotlar = new List<string>();
            List<int> tanlanganNarxlar = new List<int>();

            bool davomi = true;

            while (davomi)
            {
                Console.Write("Tanlangan mahsulotni kiriting: exit - savdodan chiqish, sale - savdoni yakunlash: ");
                Console.Clear();

                int jamiNarx = 0;
                for (int i = 0; i < tanlanganNarxlar.Count; i++)
                {
                    jamiNarx += tanlanganNarxlar[i];
                }

                string tanlanganMahsulot = Console.ReadLine();

                if (tanlanganMahsulot == "exit")
                {
                    davomi = false;
                    break;
                }
                else if (tanlanganMahsulot == "sale")
                {

                    Console.Write($"Jami savdo summasi: {jamiNarx} so'm", jamiNarx);
                    Console.Write("(buy - sotib olish, cancel - bekor qilish): ");
                    Console.Clear();

                    tanlanganMahsulot = Console.ReadLine();

                    if (tanlanganMahsulot == "buy")
                    {
                        Console.Clear();
                        Console.WriteLine("Savdoyingiz uchun tashakkur!");
                        Thread.Sleep(3000);

                        davomi = true;
                        break;
                    }
                    else if (tanlanganMahsulot == "cancel")
                    {
                        Console.Clear();
                        Console.WriteLine("Olmasang nima qilasan bizni ovora qilib eee");
                        Thread.Sleep(3000);

                        davomi = false;
                        break;

                    }

                }


                if (!tovarlar.ContainsKey(tanlanganMahsulot) && tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.WriteLine("Kechirasiz, bunday mahsulot mavjud emas.");
                    continue;
                }

                if (tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.Write("Mahsulot sonini kiriting: ");
                }


                int mahsulotSoni = Convert.ToInt32(Console.ReadLine());

                var narx = tovarlar[tanlanganMahsulot] * mahsulotSoni;

                Console.WriteLine("{0} ta tovar {1} so'mga sotib olindi", mahsulotSoni, narx);
                tanlanganMahsulotlar.Add(tanlanganMahsulot);
                tanlanganNarxlar.Add(narx);
            }
        }
        else if (tanlanganProjectlar == "oziq-ovqat")
        {
            // Oziq-ovqat do'koniga oid kodlar
            Dictionary<string, int> mahsulotlar = new Dictionary<string, int>() {
                { "Marmelad", 5000 },
                { "Choy", 7000 },
                { "Qora non", 10000 },
                { "Karam", 8000 },
                { "Choynak", 15000 },
                { "Qatiq", 9000 },
                { "Yog'urt", 11000 },
                { "Go'sht", 25000 },
                { "Pomidor", 12000 },
                { "Sabzi", 9000 }
            };

            Console.WriteLine("Assalomu alaykum! Do'konga xush kelibsiz.");
            Console.WriteLine("Bizning do'konda quyidagilar mavjud:");

            foreach (KeyValuePair<string, int> mahsulot in mahsulotlar)
            {
                Console.WriteLine("{0}. {1} - {2} so'm", Array.IndexOf(mahsulotlar.ToArray(), mahsulot) + 1, mahsulot.Key, mahsulot.Value);
            }

            List<string> tanlanganMahsulotlar = new List<string>();
            List<int> tanlanganNarxlar = new List<int>();

            bool davom = true;

            while (davom)
            {
                Console.Write("Tanlangan mahsulotni kiriting (exit - savdodan chiqish, sale - savdoni yakunlash): ");

                int jamiNarx = 0;
                for (int i = 0; i < tanlanganNarxlar.Count; i++)
                {
                    jamiNarx += tanlanganNarxlar[i];
                }

                string tanlanganMahsulot = Console.ReadLine();

                if (tanlanganMahsulot == "exit")
                {
                    davom = false;
                    break;
                }
                else if (tanlanganMahsulot == "sale")
                {

                    Console.Write($"Jami savdo summasi: {jamiNarx} so'm", jamiNarx);
                    Console.Write("(buy - sotib olish, cancel - bekor qilish): ");

                    tanlanganMahsulot = Console.ReadLine();

                    if (tanlanganMahsulot == "buy")
                    {

                        Console.WriteLine("Savdoyingiz uchun tashakkur!");
                        Thread.Sleep(3000);

                        davom = true;
                        break;
                    }
                    else if (tanlanganMahsulot == "cancel")
                    {
                        Console.WriteLine("Olmasang nima qilasan bizni ovora qilib eee");
                        Thread.Sleep(3000);

                        davom = false;
                        break;

                    }

                }


                if (!mahsulotlar.ContainsKey(tanlanganMahsulot) && tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.WriteLine("Kechirasiz, bunday taom mavjud emas.");
                    continue;
                }

                if (tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.Write("Mahsulot sonini kiriting: ");
                }


                int mahsulotSoni = Convert.ToInt32(Console.ReadLine());

                var narx = mahsulotlar[tanlanganMahsulot] * mahsulotSoni;

                Console.WriteLine("{0} ta mahsulot {1} so'mga sotib olindi", mahsulotSoni, narx);
                tanlanganMahsulotlar.Add(tanlanganMahsulot);
                tanlanganNarxlar.Add(narx);
            }
        }
        else if (tanlanganProjectlar == "restoran")
        {
            //restaurantga oid kodlar
            Dictionary<string, int> taomlar = new Dictionary<string, int>() {
                    { "Hamburger", 20000 },
                    { "Pizza", 55000 },
                    { "Qovurilgan tovuq", 45000 },
                    { "Palov", 22000 },
                    { "Tuhumbarak", 30000 },
                    { "Stake", 40000 }
                };
            Console.WriteLine("Assalomu alaykum! Restourantimizgaga xush kelibsiz.");
            Console.WriteLine("Bizning menyuda quyidagilar mavjud:");

            foreach (KeyValuePair<string, int> mahsulot in taomlar)
            {
                Console.WriteLine("{0}. {1} - {2} so'm", Array.IndexOf(taomlar.ToArray(), mahsulot) + 1, mahsulot.Key, mahsulot.Value);
            }

            List<string> tanlanganMahsulotlar = new List<string>();
            List<int> tanlanganNarxlar = new List<int>();

            bool davom = true;

            while (davom)
            {
                Console.Write("Tanlangan mahsulotni kiriting (exit - savdodan chiqish, sale - savdoni yakunlash): ");

                int jamiNarx = 0;
                for (int i = 0; i < tanlanganNarxlar.Count; i++)
                {
                    jamiNarx += tanlanganNarxlar[i];
                }

                string tanlanganMahsulot = Console.ReadLine();

                if (tanlanganMahsulot == "exit")
                {
                    davom = false;
                    break;
                }
                else if (tanlanganMahsulot == "sale")
                {

                    Console.Write($"Jami savdo summasi: {jamiNarx} so'm", jamiNarx);
                    Console.Write("(buy - sotib olish, cancel - bekor qilish): ");

                    tanlanganMahsulot = Console.ReadLine();

                    if (tanlanganMahsulot == "buy")
                    {

                        Console.WriteLine("Savdoyingiz uchun tashakkur!");
                        Thread.Sleep(3000);

                        davom = true;
                        break;
                    }
                    else if (tanlanganMahsulot == "cancel")
                    {
                        Console.WriteLine("Olmasang nima qilasan bizni ovora qilib eee");
                        Thread.Sleep(3000);

                        davom = false;
                        break;

                    }

                }


                if (!taomlar.ContainsKey(tanlanganMahsulot) && tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.WriteLine("Kechirasiz, bunday mahsulot mavjud emas.");
                    continue;
                }

                if (tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.Write("Mahsulot sonini kiriting: ");
                }


                int mahsulotSoni = Convert.ToInt32(Console.ReadLine());

                var narx = taomlar[tanlanganMahsulot] * mahsulotSoni;

                Console.WriteLine("{0} ta taom {1} so'mga sotib olindi", mahsulotSoni, narx);
                tanlanganMahsulotlar.Add(tanlanganMahsulot);
                tanlanganNarxlar.Add(narx);

            }
        }
        else if (tanlanganProjectlar == "game")
        {
            int userScore = 0;
            int computerScore = 0;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Sizning ballaringiz: {userScore}");
                Console.WriteLine($"Kompyuter ballari: {computerScore}");

                Console.Write("Tosh, qog'oz yoki qaychi? (exit exit): ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit")
                {
                    break;
                }

                Random random = new Random();
                int computerInput = random.Next(1, 4);

                switch (computerInput)
                {
                    case 1:
                        Console.WriteLine("Kompyuter tashlarni tanladi.");
                        if (userInput == "tosh")
                        {
                            Console.WriteLine("Durrang! Barakalla.");
                        }
                        else if (userInput == "qog'oz")
                        {
                            Console.WriteLine("Siz yutdingiz! Tabriklaymiz.");
                            userScore++;
                        }
                        else if (userInput == "qaychi")
                        {
                            Console.WriteLine("Kompyuter yutdi. Yana urinib ko'ring!");
                            computerScore++;
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri kiritish. Yana urinib ko'ring!");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Kompyuter qog'ozni tanladi.");
                        if (userInput == "tosh")
                        {
                            Console.WriteLine("Kompyuter yutdi. Yana urinib ko'ring!");
                            computerScore++;
                        }
                        else if (userInput == "qog'oz")
                        {
                            Console.WriteLine("Durrang! Barakalla.");
                        }
                        else if (userInput == "qaychi")
                        {
                            Console.WriteLine("Siz yutdingiz! Tabriklaymiz.");
                            userScore++;
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri kiritish. Yana urinib ko'ring!");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Kompyuter qaychini tanladi.");
                        if (userInput == "tosh")
                        {
                            Console.WriteLine("Siz yutdingiz! Tabriklaymiz.");
                            userScore++;
                        }
                        else if (userInput == "qog'oz")
                        {
                            Console.WriteLine("Kompyuter yutdi. Yana urinib ko'ring!");
                            computerScore++;
                        }
                        else if (userInput == "qaychi")
                        {
                            Console.WriteLine("Durrang! Barakalla.");
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri kiritish. Yana urinib ko'ring!");
                        }

                        break;

                    default:
                        Console.WriteLine("Xatolik! To'xtang va yana harakat qiling.");
                        break;
                }
            }

            Console.ReadKey();
        }
        else if (tanlanganProjectlar == "apteka")
        {
            Dictionary<string, int> dorilar = new Dictionary<string, int>() {
                    { "Parasetamol", 2000 },
                    { "Sitramon", 5000 },
                    { "Noshpa", 12000 },
                    { "SariqDolgitGel", 22000 },
                    { "Shprist_200ml", 4000 },
                    { "Shprist_500ml", 6000 }
                };

            Console.WriteLine("Assalomu alaykum! Restourantimizgaga xush kelibsiz.");
            Console.WriteLine("Bizning menyuda quyidagilar mavjud:");

            foreach (KeyValuePair<string, int> mahsulot in dorilar)
            {
                Console.WriteLine("{0}. {1} - {2} so'm", Array.IndexOf(dorilar.ToArray(), mahsulot) + 1, mahsulot.Key, mahsulot.Value);
            }

            List<string> tanlanganMahsulotlar = new List<string>();
            List<int> tanlanganNarxlar = new List<int>();

            bool davom = true;

            while (davom)
            {
                Console.Write("Tanlangan mahsulotni kiriting (exit - savdodan chiqish, sale - savdoni yakunlash): ");

                int jamiNarx = 0;
                for (int i = 0; i < tanlanganNarxlar.Count; i++)
                {
                    jamiNarx += tanlanganNarxlar[i];
                }

                string tanlanganMahsulot = Console.ReadLine();

                if (tanlanganMahsulot == "exit")
                {
                    davom = false;
                    break;
                }
                else if (tanlanganMahsulot == "sale")
                {

                    Console.Write($"Jami savdo summasi: {jamiNarx} so'm", jamiNarx);
                    Console.Write("(buy - sotib olish, cancel - bekor qilish): ");

                    tanlanganMahsulot = Console.ReadLine();

                    if (tanlanganMahsulot == "buy")
                    {

                        Console.WriteLine("Savdoyingiz uchun tashakkur. Sog'ayib keting!");
                        Thread.Sleep(3000);

                        davom = true;
                        break;
                    }
                    else if (tanlanganMahsulot == "cancel")
                    {
                        Console.WriteLine("Olmasang nima qilasan bizni ovora qilib eee");
                        Thread.Sleep(3000);

                        davom = false;
                        break;

                    }

                }


                if (!dorilar.ContainsKey(tanlanganMahsulot) && tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.WriteLine("Kechirasiz, bunday mahsulot mavjud emas.");
                    continue;
                }

                if (tanlanganMahsulot != "sale" && tanlanganMahsulot != "exit" && tanlanganMahsulot != "buy" && tanlanganMahsulot != "cancel")
                {
                    Console.Write("Mahsulot sonini kiriting: ");
                }


                int mahsulotSoni = Convert.ToInt32(Console.ReadLine());

                var narx = dorilar[tanlanganMahsulot] * mahsulotSoni;

                Console.WriteLine("{0} ta taom {1} so'mga sotib olindi", mahsulotSoni, narx);
                tanlanganMahsulotlar.Add(tanlanganMahsulot);
                tanlanganNarxlar.Add(narx);
            }
        }
        else
        {
            Console.WriteLine("Bunday project mavjud emas!!!");
        }
    }
}
// Mamajonov Omadbek dotNET  N7 guruh o'quvchisi