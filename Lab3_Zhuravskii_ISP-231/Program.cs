using System;
class Program
{
    static void Main()
    {
        //int sum = 0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    sum += i;
        //}
        //Console.WriteLine($"Сумма - {sum}");

        //int k = -1;
        //do 
        //{
        //    Console.WriteLine(k);
        //    k--;
        //}
        //while (k > 0);

        //string text = "Hello world!";
        //foreach (char symbol in text) 
        //{ 
        //    Console.WriteLine(symbol);
        //}

        //for (int i = 1; i < 10; i++)
        //{
        //    for (int h = 1; h < 10; h++)
        //    {
        //        Console.Write($"{i * h}\t");
        //    }
        //    Console.WriteLine();
        //}


        //Console.ForegroundColor = ConsoleColor.DarkRed;
        //for (int i = 0; i < 0; i++)

        //{
        //    if (i == 5) continue;
        //    Console.WriteLine(i);
        //}

        //while (true)
        //{
        //    string input = Console.ReadLine();
        //    if (input == "выход") break;
        //    Console.WriteLine(input);
        //}
        //TaskPriority priority = TaskPriority.High;
        //Console.WriteLine((int)priority);

        //DayOfWeek day = DayOfWeek.Понедельник;
        //Console.WriteLine(day);

        //DayOfWeek day2 = DayOfWeek.Суббота;
        //switch (day2)
        //{
        //    case DayOfWeek.Суббота:
        //    case DayOfWeek.Воскресеньее:
        //        Console.WriteLine("Выходной!");
        //        break;
        //    default:
        //        Console.WriteLine("Будний день.");
        //        break;
        //}
        //enum DayOfWeek { Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье }


        //enum TaskPriority
        //{
        //    Low = 1,
        //    Medium = 2,
        //    High = 3,

        //}
        //enum Hero { воин, маг, вор }
        //enum TimeOfDay { Утро, День, Вечер, Ночь }
        //class Program
        //{
        //    static void Main()
        //    {
        //        var times = Enum.GetValues(typeof(TimeOfDay));
        //        var heroes = Enum.GetValues(typeof(Hero));

        //        for (int i = 0; i < times.Length; i++)
        //        {
        //            TimeOfDay time = (TimeOfDay)times.GetValue(i);
        //            Console.WriteLine($"\nВремя сейчас: {time}");

        //            for (int j = 0; j < heroes.Length; j++)
        //            {
        //                Hero h = (Hero)heroes.GetValue(j);
        //                Console.Write($"{h} - ");

        //                switch (time)
        //                {
        //                    case TimeOfDay.Утро:
        //                        Console.WriteLine(h switch
        //                        {
        //                            Hero.воин => "делает зарядку с мечом",
        //                            Hero.маг => "заваривает зелья",
        //                            Hero.вор => "крадётся по базару",
        //                            _ => "ничего не делает"
        //                        });
        //                        break;
        //                    case TimeOfDay.День:
        //                        Console.WriteLine(h switch
        //                        {
        //                            Hero.воин => "тренируется на арене",
        //                            Hero.маг => "изучает древние книги",
        //                            Hero.вор => "прячется в тенях",
        //                            _ => ""
        //                        });
        //                        break;
        //                    case TimeOfDay.Вечер:
        //                        Console.WriteLine(h switch
        //                        {
        //                            Hero.воин => "ест мясо у костра",
        //                            Hero.маг => "создаёт магический щит",
        //                            Hero.вор => "планирует налёт",
        //                            _ => ""
        //                        });
        //                        break;
        //                    case TimeOfDay.Ночь:
        //                        Console.WriteLine(h switch
        //                        {
        //                            Hero.воин => "спит в палатке",
        //                            Hero.маг => "медитирует под луной",
        //                            Hero.вор => "лезет в чужой дом",
        //                            _ => ""
        //                        });
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}
        //ДЗ
        //ЗАДАНИЕ(1)
        //enum TrafficLight { Red, Yellow, Green }

        //class Program
        //{
        //    static void Main()
        //    {
        //        TrafficLight current = TrafficLight.Green;
        //        TrafficLight next = GetNextLight(current);
        //        Console.WriteLine($"После {current} будет {next}");
        //    }

        //    static TrafficLight GetNextLight(TrafficLight current)
        //    {
        //        return current switch
        //        {
        //            TrafficLight.Red => TrafficLight.Yellow,
        //            TrafficLight.Yellow => TrafficLight.Green,
        //            TrafficLight.Green => TrafficLight.Red,
        //            _ => TrafficLight.Red
        //        };
        //    }
        //}
        //ЗАДАНИЕ 2
        //enum OrderStatus { New, Processing, Shipped, Delivered }

        //class Program
        //{
        //    static void Main()
        //    {
        //        Console.WriteLine(CanCancelOrder(OrderStatus.New)); 
        //        Console.WriteLine(CanCancelOrder(OrderStatus.Shipped)); 
        //    }

        //    static bool CanCancelOrder(OrderStatus status)
        //    {
        //        return status == OrderStatus.New || status == OrderStatus.Processing;
        //    }
        //}
        //ЗАДАНИЕ 3
        //for (int i = 10; i >= 1; i--)
        //{
        //    Console.WriteLine(i);
        //}
        ////ЗАДАНИЕ 4
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"5 * {i} = {5 * i}");

        //}
        ////ЗАДАНИЕ 5
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
        //}
        //ЗАДАНИЕ 6
        //Console.Write("Введите число n: ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i <= n; i++)
        //{
        //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        //}
        //ЗАДАНИЕ 7
        //Console.Write("Введите предложение: ");
        //string man = Console.ReadLine();

        //Console.Write("Введите количество повторений: ");
        //int count = int.Parse(Console.ReadLine());

        //for (int i = 0; i < count; i++)
        //{
        //    Console.WriteLine(man);
        //}
        //ЗАДАНИЕ 8
        //bool allEven = true;

        //for (int i = 0; i < 10; i++)
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    if (number % 2 != 0)
        //    {
        //        allEven = false;
        //    }
        //}

        //Console.WriteLine(allEven ? "YES" : "NO");
        //ЗАДАНИЕ 9
        //Console.WriteLine("Добро пожаловать на стрельбище!");
        //Console.WriteLine("Введите 'Стоп', чтобы завершить стрельбу.");
        //int shotsFired = 0;
        //for (int i = 1; ; i++)
        //{
        //    Console.Write("Нажмите Enter для выстрела: ");
        //    string input = Console.ReadLine();
        //    if (input?.ToLower() == "стоп") break;
        //    Console.WriteLine("Выстрел совершен.");
        //    shotsFired++;
        //}
        //Console.WriteLine($"Стрельба завершена.");
        //Console.WriteLine($"Израсходовано боеприпасов: {shotsFired}");
    }
}
