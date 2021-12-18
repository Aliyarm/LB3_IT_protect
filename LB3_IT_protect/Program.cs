using System;

namespace LB3_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину масссива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new();
            Console.WriteLine("Изначальный масссив.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            bool sign = array[0] > 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (sign == true && array[i] != 0)
                {
                    for (int j = i + 1; sign == true && j < array.Length; j++)
                    {
                        if (array[j] > 0)
                        {
                            array[j] = 0;
                        }
                        else
                        {
                            sign = !sign;
                        }
                    }
                }
                else if (sign == false && array[i] != 0)
                {
                    for (int j = i + 1; sign == false && j < array.Length; j++)
                    {
                        if (array[j] < 0)
                        {
                            array[j] = 0;
                        }
                        else
                        {
                            sign = !sign;
                        }
                    }
                }
            }

            int newLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    newLength++;
            }
            int[] newArray = new int[newLength];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Преобразованный массив.");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}