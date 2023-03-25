using System.Text;
using System.Text.Unicode;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zodiac>? Zodiacs = null;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            for (; ; )
            {
                int Input = GetAction();

                switch(Input)
                {
                    case 1:
                        Zodiacs = FillZodiacPeoples();
                        break;
                    case 2:
                        PrintZodiacPeople(Zodiacs);
                        break;
                    case 3:
                        Console.WriteLine("Конец");
                        return;
                    default:
                        continue;
                }
            }
        }

        static int GetAction()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - Ввод знаков задиака");
            Console.WriteLine("2 - Вывод людей по знаку зодиака");
            Console.WriteLine("3 - Выход");
            Console.Write("Действие: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static public List<Zodiac> FillZodiacPeoples()
        {
            List<Zodiac> Zodiacs = new List<Zodiac>();

            for(; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Создание записи с человеком по имени");
                Console.Write("Имя: ");
                string FirstName = Console.ReadLine();
                Console.Write("Фамилия: ");
                string LastName = Console.ReadLine();
                Console.Write("Знак зодиака: ");
                string ZodiacName = Console.ReadLine();
                Console.Write("День рождения: ");
                DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                Zodiacs.Add(new Zodiac(FirstName, LastName, ZodiacName, DateOfBirth));

                Console.Write("Хотите продолжить? (1/0): ");
                int Result = Convert.ToInt32(Console.ReadLine());
                if (Result == 0)
                    break;
            }

            return Zodiacs;
        }

        static public void PrintZodiacPeople(List<Zodiac> Zodiacs)
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.Write("Введите имя человека:");
                string Name = Console.ReadLine();

                Zodiac? Item = null;
                if((Item = Zodiacs.Find(n => n.FirstName == Name)) != null)
                    Console.WriteLine($"{Item.FirstName} {Item.LastName} {Item.ZodiacName} {Item.DateOfBirth}");
                else
                    Console.WriteLine("Такой записи не найдено. Попробуйте снова");

                Console.Write("Хотите продолжить? (1/0): ");
                int Result = Convert.ToInt32(Console.ReadLine());
                if (Result == 0)
                    break;
            }
        }
    }
}