using System;

namespace Converting_Method_App
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Какую команду Вы хотите выполнить?:");
            Console.WriteLine("Преобразовать string = -7,77,7a77 в double. Нажмите 1:");
            Console.WriteLine("Преобразовать string = 7,77,7a77 в double. Нажмите 2:");
            Console.WriteLine("Преобразовать string = ,77a7 в double. Нажмите 3:");

            while (true)
            {
                int userinput = int.Parse(Console.ReadLine());

                int Program = userinput;

                switch (Program)
                {
                    case 1:
                        {
                            string input = "-7,77,7a77";

                            double result = Converter.StringToDouble(input);

                            Console.WriteLine(result);

                            break;
                        }

                    case 2:
                        {
                            string input = "7,77,7a77";

                            double result = Converter.StringToDouble(input);

                            Console.WriteLine(result);

                            break;
                        }

                    case 3:
                        {
                            string input = ",77a7";

                            double result = Converter.StringToDouble(input);

                            Console.WriteLine(result);

                            break;
                        }
                }
            }
        }

    }
}