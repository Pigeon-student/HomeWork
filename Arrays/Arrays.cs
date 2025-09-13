class Arrays
{
    enum weakDay
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    static void Main()
    {

        #region FirstSecondTask

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("1. Створити масив із 10 елементів типу int." +
            "\nПрисвоїти їм випадкові значення від -10 до 10, використовуючи клас Random." +
            "\nВивести на екран елементи масиву з парним індексом.\n");

        int[] array = new int[10];

        const int minValue = -10;
        const int maxValue = 10;

        int arraySumm = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(minValue, maxValue);

            array[i] = randomNumber;

            arraySumm += array[i];           // Sum the values ​​of the array

            if (i % 2 == 0 && i != 0)        // Display values ​​with an even index
            {
                Console.WriteLine($"Eve index: {i}");
            }
        }

        Console.WriteLine("\n2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число:");

        if (arraySumm < 0) // We define that the sum of array elements is a non-negative number
        {
            Console.WriteLine($"Array's numbers summa = {arraySumm}, it's negative ;(\n");
        }
        else
        {
            Console.WriteLine($"Array's numbers summa = {arraySumm}, it's positive :)\n");
        }

        #endregion


        #region ThirdTask

        Console.WriteLine("3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення\n");

        const int SIZE = 9;

        int[,] tableHanded = new int[SIZE, SIZE]
            {
                {1, 2,  3,  4,  5,  6,  7,  8,  9  },
                {2, 4,  6,  8,  10, 12, 14, 16, 18 },
                {3, 6,  9,  12, 15, 18, 21, 24, 27 },
                {4, 8,  12, 16, 20, 24, 28, 32, 36 },
                {5, 10, 15, 20, 25, 30, 35, 40, 45 },
                {6, 12, 18, 24, 30, 36, 42, 48, 54 },
                {7, 14, 21, 28, 35, 42, 49, 56, 63 },
                {8, 16, 24, 32, 40, 48, 56, 64, 72 },
                {9, 18, 27, 36, 45, 54, 63, 72 ,81 },
            };



        int[,] tableAuto = new int[SIZE, SIZE];

        for (int i = 0; i < tableAuto.GetLength(0); i++)
        {
            for (int j = 0; j < tableAuto.GetLength(0); j++)
            {
                tableAuto[i, j] = (i + 1) * (j + 1);
                Console.Write($"{tableAuto[i, j],3}");

            }
            Console.WriteLine();
        }
        Console.WriteLine();

        #endregion


        #region FourthTask

        Console.WriteLine("4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами.\n");

        const int RAWS = 5;
        const int COLLUMNS = 5;

        // craating array

        int[,] penta = new int[RAWS, COLLUMNS];

        for (int i = 0; i < penta.GetLength(0); i++)
        {
            for (int j = 0; j < penta.GetLength(0); j++)
            {
                Random randomNumLink = new Random();

                penta[i, j] = randomNumLink.Next(1, 100);
                Console.Write($"{penta[i, j]}\t");         // for confort view
            }
            Console.WriteLine();                            // for confort view
        }

        // max value

        Console.WriteLine("\n4.1 Bивести на екран максимальний елемент масиву:");

        int tempMax = 0;   // temporary variable to find largest number

        for (int i = 0; i < RAWS; i++)
        {
            for (int j = 0; j < penta.GetLength(0); j++)
            {
                if (penta[i, j] > tempMax)
                {
                    tempMax = penta[i, j];
                }
            }
        }

        Console.WriteLine($"The largest number in array is: {tempMax}");

        // Find index of the largest number

        Console.WriteLine("\n4.2 Bивести на екран координати максмального елемента масиву:");

        for (int i = 0; i < penta.GetLength(0); i++)
        {
            for (int j = 0; j < penta.GetLength(0); j++)
            {
                if (penta[i, j] == tempMax)
                    Console.WriteLine($"Index of the largest number is: {i}-{j}");
            }
        }
        // min value

        Console.WriteLine("\n4.3 Bивести на екран мінімальний елемент масиву:");

        int tempMin = penta[0, 0];   // temporary variable to find smallest number

        for (int i = 0; i < RAWS; i++)
        {
            for (int j = 0; j < COLLUMNS; j++)
            {
                if (penta[i, j] < tempMin)
                {
                    tempMin = penta[i, j];
                }
            }
        }

        Console.WriteLine($"The smallest number in array is: {tempMin}");

        // Find adress of the smallest value

        Console.WriteLine("\n4.4 Bивести на екран координати мінімального елемента масиву:");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (penta[i, j] == tempMin)
                {
                    Console.WriteLine($"The smallest value's index is: {i}-{j} ");
                }
            }
        }

        #endregion


        #region FifthTask


        System.Console.WriteLine("\n5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів; " +
            "\nПотім рахувати який буде день через введену кількість (якщо рахувати від понеділка) і виводити результат.");

        System.Console.Write("\nEnter number days: ");
        int userInput = int.Parse(Console.ReadLine());
              
        weakDay weakDay = (weakDay)(userInput % 7);

        Console.WriteLine($"Expecto {weakDay}");

        #endregion

    }
}