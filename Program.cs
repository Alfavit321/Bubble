using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива :");
            int Num = int.Parse(Console.ReadLine());
            int[] array = new int[Num];

            Console.WriteLine("Введите элементы массива :");
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Work.BubbleSort(array);//сама работа метода

            Console.WriteLine("Отсортированный массив :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
