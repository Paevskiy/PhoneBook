using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Title = { "No", "Name", "SurName", "Phone Number" };
            string[] ListName =
            {   "Бажен",
                "Бенедикт",
                "Богдан",
                "Бореслав",
                "Болеслав",
                "Боримир",
                "Борис",
                "Борислав",
                "Бронислав",
                "Будимир"
            };
            string[] ListSurname =
            {
                "Иванов",
                "Васильев",
                "Петров",
                "Смирнов",
                "Михайлов",
                "Фёдоров",
                "Соколов",
                "Яковлев",
                "Попов",
                "Алексеев"
            };
            string[] PhoneNumber =
            {   "89611176700",
                "89611176701",
                "89611176702",
                "89611176703",
                "89611176704",
                "89611176705",
                "89611176706",
                "89611176707",
                "89611176708",
                "89611176709"};
            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |", Title[0], Title[1], Title[2], Title[3]);
            for (int a = 0; a < 49; a++)
                Console.Write("-");
            Console.WriteLine();
            for (int i = 0; i < PhoneNumber.Length; i++)
            {
                Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |", i + 1, ListName[i], ListSurname[i], PhoneNumber[i]);
            }
            for (int a = 0; a < 49; a++)
                Console.Write("-");

            Console.WriteLine();

            Console.WriteLine(@"Available operation are listed below:

""Remove""
""Add""
""Edit""

Please, type command" + "\n");
            string command = Console.ReadLine();
            switch (command.ToLowerInvariant())
            {
                case "remove":
                    Console.WriteLine("Please type index of line for removing");
                    int Index1 = Int32.Parse(Console.ReadLine());
                    ListName[Index1 - 1] = null;
                    ListName=ListName.Where(x => x != null).ToArray();
                    ListSurname[Index1 - 1] = null;
                    ListSurname = ListSurname.Where(x => x != null).ToArray();
                    PhoneNumber[Index1 - 1] = null;
                    PhoneNumber = PhoneNumber.Where(x => x != null).ToArray();
                    //fruits = fruits.Where(x => x != null).ToArray();
                    break;

                case "add":
                    try
                    {
                        Console.WriteLine("Please Name and press Enter");
                        Array.Resize(ref ListName, ListName.Length + 1);
                        ListName[ListName.Length - 1] = Console.ReadLine();
                        Console.WriteLine("Please Surname and press Enter");
                        Array.Resize(ref ListSurname, ListSurname.Length + 1);
                        ListSurname[ListSurname.Length - 1] = Console.ReadLine();
                        Console.WriteLine("Please PhoneNumber and press Enter");
                        Array.Resize(ref PhoneNumber, PhoneNumber.Length + 1);
                        PhoneNumber[PhoneNumber.Length - 1] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |",
                            ListName.Length,
                            ListName[ListName.Length - 1],
                            ListSurname[ListSurname.Length - 1],
                            PhoneNumber[PhoneNumber.Length - 1]);

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {

                    }

                    break;
                case "edit":
                    try
                    {
                        Console.WriteLine("Please type index of line for editing");
                        int Index = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please change Name {0} and press Enter", ListName[Index - 1]);
                        ListName[Index - 1] = Console.ReadLine();
                        Console.WriteLine("Please change Surname {0} and press Enter", ListSurname[Index - 1]);
                        ListSurname[Index - 1] = Console.ReadLine();
                        Console.WriteLine("Please change PhoneNumber {0} and press Enter", PhoneNumber[Index - 1]);
                        PhoneNumber[Index - 1] = Convert.ToString(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                    break;
                default:
                    Console.WriteLine("\nInput Error, Please try again\n");
                    Console.ReadKey();
                    break;


            }
            //программа не дописана, ниже приведенный код используется для проверки изменений БД
            Console.Clear();
            Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |", Title[0], Title[1], Title[2], Title[3]);
            for (int a = 0; a < 49; a++)
                Console.Write("-");
            Console.WriteLine();
            for (int i = 0; i < PhoneNumber.Length; i++)
            {
                Console.WriteLine("{0,2} | {1,-12} | {2,-12} | {3,12} |", i + 1, ListName[i], ListSurname[i], PhoneNumber[i]);
            }
            for (int a = 0; a < 49; a++)
                Console.Write("-");

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

