using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10.PracticWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.Write("Введите число для проверки на чётность: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");

            Console.ReadKey();
            #endregion

            #region Task 2
            Console.Write("Здравствуйте! Я подсчитаю сумму ваших карт в игре '21'. Введите сколько карт у Вас на руках: ");
            int cards = int.Parse(Console.ReadLine());
            int cardSum = 0;
            Console.WriteLine("Доступные карты: от 2 до 10, а также:\nJ - Валет\nQ - Дама\nK - Король\nT - Туз");
            for (int i = 1; i <= cards; i++)
            {
                Console.WriteLine($"Введите {i}-ю карту из {cards}: ");

                var card = Console.ReadLine();
                if (card.Equals("T") || card.Equals("J") || card.Equals("Q") || card.Equals("K"))
                    cardSum += 10;
                else
                {
                    if (int.Parse(card) < 2 || int.Parse(card) > 10)
                    {
                        Console.WriteLine("Неправильно введенная карта");
                        break;
                    }
                    switch (int.Parse(card))
                    {
                        case 2: cardSum += 2; break;
                        case 3: cardSum += 3; break;
                        case 4: cardSum += 4; break;
                        case 5: cardSum += 5; break;
                        case 6: cardSum += 6; break;
                        case 7: cardSum += 7; break;
                        case 8: cardSum += 8; break;
                        case 9: cardSum += 9; break;
                        case 10: cardSum += 10; break;
                    }
                }
            }
            Console.WriteLine($"Сумма всех карт: {cardSum} очка(ов)");
            Console.ReadKey();
            #endregion

            #region Task 3
            Console.Write("Введите число для проверки его простоты: ");
            int num = int.Parse(Console.ReadLine());
            bool primeNum = true;
            int j = 2;
            while (j <= num - 1)
            {
                if (num % j == 0)
                {
                    primeNum = false;
                    break;
                }
                j++;
            }
            Console.WriteLine(primeNum ? "Число простое" : "Число не простое");
            Console.ReadKey();
            #endregion

            #region Task 4
            Console.Write("Наименьший элемент в последовательности!\nВведите длину последовательности: ");
            int count = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int enteredValue;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Введите {i} число последовательности: ");
                enteredValue = int.Parse(Console.ReadLine());
                if (enteredValue < minValue)
                    minValue = enteredValue;
            }
            Console.WriteLine($"Наименьшее число из последовательности: {minValue}");
            Console.ReadKey();
            #endregion

            #region Task 5
            Console.Write("Давайте поиграем в игру 'Угадай число'\nВведите максимальное число до которого я могу загадать: ");
            int maxValue = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int numValue = rand.Next(0, maxValue);
            Console.Write("Я загадал число! Как Вы думаете, какое?\nВведите число: ");
            while(true)
            {
                string myValue = Console.ReadLine();
                if(myValue == string.Empty)
                {
                    Console.WriteLine($"Было приятно с Вами поиграть! Загаданное число было '{numValue}'");
                    break;
                }
                else
                {
                    if (int.Parse(myValue) > maxValue)
                        Console.Write($"Максимальное число, которое может быть загадано составляет '{maxValue}'\nВведите число: ");
                    else if (int.Parse(myValue) > numValue)
                        Console.Write("Загаданное число меньше Вашего\nВведите число: ");
                    else if (int.Parse(myValue) < numValue)
                        Console.Write("Загаданное число больше Вашего\nВведите число: ");
                    else
                    {
                        Console.WriteLine($"Вы угадали! Это было число {numValue}");
                        break;
                    }
                }
                
            }
            Console.ReadKey();
            #endregion
        }
    }
}
