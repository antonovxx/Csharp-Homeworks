using System;

// Задание 2. Программа подсчёта суммы карт в игре «21».
namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int numberOfCard;
            char letterOfCard;
            int i = 0;

            Console.WriteLine("Enter number of cards: ");

            int countCards = int.Parse(Console.ReadLine());

            while(i < countCards)
            {       
                Console.WriteLine("Enter the value of the card: ");

                string card = Console.ReadLine();

                bool isNumber = int.TryParse(card, out numberOfCard);
              
                if (isNumber)
                {
                    if (numberOfCard > 0 && numberOfCard <= 10)
                    {
                        sum += numberOfCard;
                        ++i;
                    }
                    else
                        Console.WriteLine("Incorrect value");
                } else if (isNumber is not true)
                {
                    char.TryParse(card, out letterOfCard);
                    switch (letterOfCard)
                    {
                        case 'J':
                            sum += 2;
                            ++i;
                            break;
                        case 'Q':
                            sum += 3;
                            ++i;
                            break;
                        case 'K':
                            sum += 4;
                            ++i;
                            break;
                        case 'T':
                            sum += 11;
                            ++i;
                            break;
                        default:
                            Console.WriteLine("Incorrect value");
                            break;
                    }
                } else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            Console.WriteLine("Sum of the cards: " + sum);
        }
    }
}