using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_03_23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            /*string[] arr = { "2", "1", "3", "6", "@", "B", "5", "8", "9", "12", "h", "31", "~", "#", "`" };
            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = 0;

            foreach(var item in arr)
            {
                int number;
                if(int.TryParse(item, out number))
                {
                    if(number % 2 == 0) evenCount++;
                    else oddCount++;
                }
                else uniqueCount++;                
            }

            Console.WriteLine("Четных элементов: " + evenCount);
            Console.WriteLine("Нечетных элементов: " + oddCount);
            Console.WriteLine("Уникальных элементов: " + uniqueCount);*/
            #endregion

            #region 2
            /*const int itemCount = 30;
            int[] arr = new int[itemCount];
            int countNumber = 0;

            Random r = new Random();
            for (int item = 0; item < itemCount; ++item)
            {
                arr[item] = r.Next(0, 100);
                Console.Write($"{arr[item]} ");
            }
            Console.WriteLine();

            int minValue = arr.Min();
            int maxValue = arr.Max();

            Console.Write($"Введите число от {minValue} до {maxValue}: ");
            int userAnswerNumber = int.Parse(Console.ReadLine());
            if(userAnswerNumber < minValue || userAnswerNumber > maxValue)
            {
                Console.WriteLine("Ошибка. Вы вышли за диапазон");
                return;
            }
            else
            {
                foreach(int item in arr)                
                    if (item < userAnswerNumber)
                        countNumber++;                
            }

            Console.WriteLine($"Значений меньше чем {userAnswerNumber}: {countNumber}");*/
            #endregion

            #region 3
            /*int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5, 1, 2, 5, 1, 2, 5 };
            int count = 0;
            
            Console.WriteLine("Введите три цифры: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 2; i++)            
                if (array[i] == a && array[i + 1] == b && array[i + 2] == c)
                    count++;

            Console.WriteLine($"Последовательность {a}, {b}, {c}, повторяется {count} раз");*/
            #endregion

            #region 4
            /*const int length = 20;
            int lengthResultArray = 0;
            int[] arr1 = new int[length] { 4, 12, 43, 54, 23, 65, 1, 6, 8, 3, 7, 8, 15, 65, 76, 87, 90, 0, 11, 2 };
            int[] arr2 = new int[length] { 1, 4, 5, 2, 6, 7, 2, 4, 6, 12, 53, 65, 76, 34, 11, 43, 65, 6, 4, 90 };

            foreach (int item in arr1)
            {
                int count = 0;
                if (arr2.Contains(item))
                {
                    if (count == 0)
                    {
                        lengthResultArray++;
                        count++;
                    }
                    else
                        break;
                }
            }

            int[] resultArray = new int[lengthResultArray];
            int index = 0;

            foreach (int item in arr1)
            {
                int count = 0;
                if (arr2.Contains(item))
                {
                    if (count == 0)
                    {
                        resultArray[index++] = item;
                        count++;
                    }
                    else
                        break;
                }
            }

            Console.Write("Result array = ");
            foreach (var item in resultArray) Console.Write($"{item} ");
            Console.WriteLine();*/
            #endregion

            #region 5
            /*const int row = 3;
            const int column = 6;
            int[,] array = new int[row, column];

            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    array[i, k] = r.Next(0, 100);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    Console.Write($"{array[i, k]}  ");
                }
                Console.WriteLine();
            }

            int arrMaxX = 0;
            int arrMaxY = 0;
            int arrMinX = 0;
            int arrMinY = 0;

            for (int i = 0; i < row; i++)
            {
                for (int k = 1; k < column; k++)
                {
                    if (array[i, k] > array[arrMaxX, arrMaxY])
                    {
                        arrMaxX = i;
                        arrMaxY = k;
                    }

                    if (array[i, k] < array[arrMinX, arrMinY])
                    {
                        arrMinX = i;
                        arrMinY = k;
                    }
                }
            }

            Console.WriteLine($"Макс значение: {array[arrMaxX, arrMaxY]}");
            Console.WriteLine($"Мин значение: {array[arrMinX, arrMinY]}");*/
            #endregion

        }
    }
}
