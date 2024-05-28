namespace ConverterConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            double USD = 3.27;
            
            double EUR = 3.14;
            
            double rateEURtoUSD = 1.09;

            double compareSum;
            string changeFromStr, changeToStr;
            string cycleCondition = "";

            Console.WriteLine("Конвертер валют\n");

            Console.Write("Введите количество у Вас рублей: ");
            double bynN = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество у Вас долларов: ");
            double usdN = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество у Вас евро: ");
            double eurN = Convert.ToDouble(Console.ReadLine());

            while (cycleCondition != "exit")
            {
                Console.Clear();

                Console.SetCursorPosition(13, 0);
                Console.WriteLine("Текущий курс валют:\n");
                Console.WriteLine($"Купить USD: {USD} BYN, "
                                  + $"Купить EUR: {EUR} BYN,\n");

                Console.SetCursorPosition(13, 4);
                Console.WriteLine($"Обменять EUR/USD: {rateEURtoUSD}\n");
                Console.WriteLine($"У Вас {bynN} рублей, {usdN} долларов, {eurN} евро\n");

                Console.Write("Какую валюту хотите поменять?\n" +
                              "1-рубли, 2-доллары, 3-евро: ");
                changeFromStr = Console.ReadLine();

                if (changeFromStr == "1")
                    compareSum = bynN;
                else if (changeFromStr == "2")
                    compareSum = usdN;
                else if (changeFromStr == "3")
                    compareSum = eurN;
                else
                    continue;

                Console.Write("Введите сумму обмена: ");
                double changeSum = Convert.ToDouble(Console.ReadLine());

                if (changeSum > compareSum || changeSum == 0)
                    continue;

                Console.Write("Какую валюту хотите получить?\n" +
                              "1-рубли, 2-доллары, 3-евро: ");
                changeToStr = Console.ReadLine();

                if (changeToStr == "1")
                {
                    if (changeFromStr == "2")
                    {
                        bynN += changeSum * USD;
                        usdN -= changeSum;
                    }
                    else if (changeFromStr == "3")
                    {
                        bynN += changeSum * EUR;
                        eurN -= changeSum;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (changeToStr == "2")
                {
                    if (changeFromStr == "1")
                    {
                        usdN += changeSum / USD;
                        bynN -= changeSum;
                    }
                    else if (changeFromStr == "3")
                    {
                        usdN += changeSum * rateEURtoUSD;
                        eurN -= changeSum;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (changeToStr == "3")
                {
                    if (changeFromStr == "1")
                    {
                        eurN += changeSum / EUR;
                        bynN -= changeSum;
                    }
                    else if (changeFromStr == "2")
                    {
                        eurN += changeSum / rateEURtoUSD;
                        usdN -= changeSum;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"Обмен произведён.\n" +
                                  $"У Вас {bynN} рублей, {usdN} долларов, {eurN} евро\n");

                Console.WriteLine("Для продолжения нажмите Enter,\n" +
                                  "для выхода из программы введите exit и нажмите Enter");

                cycleCondition = Console.ReadLine();

            }
        }
    }
}


