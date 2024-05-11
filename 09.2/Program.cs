using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._2
{
    public class Indexer
    {
        private int[] array;

        public Indexer(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (value % 2 != 0 && value != 0)
                {
                    array[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть розмір масиву : ");
            int size = Convert.ToInt32(Console.ReadLine());

            Indexer myArray = new Indexer(size);

            Random rand = new Random();
            int randomNumber;
            myArray[0] = 1;

            for (int i = 0; i < size; i++)
            {
                do
                {
                    randomNumber = rand.Next(1, 10);
                } while (randomNumber % 2 == 0 || randomNumber == 0);

                myArray[i] = randomNumber;
            }

            for (int j = 0; j < size; j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"| {myArray[j]} ");
            }
            Console.WriteLine("|");
            Console.ResetColor();

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
