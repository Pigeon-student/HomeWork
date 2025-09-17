using System;
using System.Xml.Linq;

class Sorting
{
    static void Main()
    {
        Random rand = new Random();

        int[] arr = new int[55];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 1000);
        }

        //foreach (int index in arr)
        //{
        //    Console.Write($"{index} ");
        //}

        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr.Length - 1; k++)
            {
                if (arr[k] > arr[k + 1])
                {
                    arr[k] += arr[k + 1];
                    arr[k + 1] = arr[k] - arr[k + 1];
                    arr[k] -= arr[k + 1];

                }
            }

        }

        //foreach (int index in arr)
        //{
        //    Console.Write($"{index} ");
        //}

        Console.WriteLine(arr[arr.Length - 2]);

        Console.WriteLine($"\n\t Task #2\n");

        //------------------------------------------------------------------------------------------------------

        const int FIRSTUNDERARRAYLENGTH = 16;
        const int SECONDUNDERARRAYLENGTH = 25;

        int[][] array = new int[2][];

        array[0] = new int[FIRSTUNDERARRAYLENGTH];
        array[1] = new int[SECONDUNDERARRAYLENGTH];

        Random xz = new Random();

        for (int i = 0; i < array[0].Length; i++)
        {
            array[0][i] = xz.Next(1, 100);
        }

        for (int i = 0; i < array[1].Length; i++)
        {
            array[1][i] = xz.Next(1, 100);
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                for (int k = 0; k < array[i].Length - 1; k++)
                {
                    if (array[i][k] > array[i][k + 1])
                    {
                        array[i][k] += array[i][k + 1];
                        array[i][k + 1] = array[i][k] - array[i][k + 1];
                        array[i][k] -= array[i][k + 1];
                    }
                }
            }
        }

        Console.WriteLine();


        foreach (int[] innerArray in array)
        {
            foreach (int item in innerArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nAnother way:"); //----------------------------------------------------------------

        const int ARRAYLENGHT = 3;
        int counter = 0;

        int[,] anArray = new int[ARRAYLENGHT, ARRAYLENGHT] { { 3, 2, 1 }, { 9, 8, 7 }, { 4, 6, 5 } };

        Console.WriteLine();

        //foreach (int pok in anArray)
        //{
        //    Console.Write($"{pok} ");
        //    counter++;
        //    if (counter % ARRAYLENGHT == 0)
        //        Console.WriteLine();
        //}
        //Console.WriteLine();

        for (int i = 0; i < ARRAYLENGHT; i++)
        {
            for (int k = 0; k < ARRAYLENGHT; k++)
            {
                for (int j = 0; j < ARRAYLENGHT - 1; j++)
                {
                    if (anArray[i, j] > anArray[i, j + 1])
                    {
                        anArray[i, j] += anArray[i, j + 1];
                        anArray[i, j + 1] = anArray[i, j] - anArray[i, j + 1];
                        anArray[i, j] -= anArray[i, j + 1];
                    }
                }
            }
        }

        //foreach (int pok in anArray)
        //{
        //    Console.Write($"{pok} ");
        //    counter++;
        //    if (counter % ARRAYLENGHT == 0)
        //        Console.WriteLine();
        //}
        //Console.WriteLine();


        for (int i = 0; i < ARRAYLENGHT; i++)
        {
            for (int j = 0; j < ARRAYLENGHT; j++)
            {
                for (int k = 0; k < ARRAYLENGHT - 1; k++)
                {
                    if (anArray[k, i] > anArray[k + 1, i])
                    {
                        anArray[k, i] += anArray[k + 1, i];
                        anArray[k + 1, i] = anArray[k, i] - anArray[k + 1, i];
                        anArray[k, i] -= anArray[k + 1, i];

                    }
                }

            }
        }

        foreach (int innerArray in anArray)
        {
            Console.Write($"{innerArray} ");
            counter++;

            if (counter % ARRAYLENGHT == 0)
                Console.WriteLine();
        }
        Console.WriteLine($"\n\tTask #3\n"); //-----------------------------------------------------------------------------------------------------------------

        int[] arra = new int[10] { 1, 6, 2, 8, 23, 64, 234, 67, 123, 567 };

        foreach (int elem in arra)
        {
            Console.Write($"{elem} ");
        }

        Console.Write($"\nEnter index of the number to delete (0-9): ");

        int userNumber = int.Parse(Console.ReadLine());

        int[] newArra = new int[9];

        for (int i = 0; i < newArra.Length; i++)
        {
            if (arra[i] != arra[userNumber])
            {
                newArra[i] = arra[i];
            }
            else
            {
                for (int j = i; j < newArra.Length; j++)
                {
                    newArra[j] = arra[j + 1];
                }
                break;
            }
        }

        Console.WriteLine();
        foreach (int elem in newArra)
        {
            Console.Write($"{elem} ");
        }
        Console.WriteLine();

        Console.WriteLine($"\nTask #4:\n"); //-----------------------------------------------------------------------------------------------------------------


        Console.Write("Enter the size of the 2D array: ");
        int size = int.Parse(Console.ReadLine());

        Random random = new Random();
       
        int[,] mass = new int[size, size];

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                mass[i, j] = random.Next(1, 100);
            }
        }

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
                            {
                Console.Write($"{mass[i, j]} ");
            }

            Console.WriteLine();
        }

        int temp = 0;

        for (int i = 0, j = 0; i < mass.GetLength(1); i++, j++)
        {
            temp +=  mass[i, j];
           
        }
        Console.WriteLine(temp);











































    }
}