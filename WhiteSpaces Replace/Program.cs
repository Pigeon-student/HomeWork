using System.Diagnostics.Metrics;
using System.Text;

class WhiteSpaces
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Enter string: ");
        StringBuilder text = new StringBuilder(Console.ReadLine());

        text.Replace(" ", "");

        Console.WriteLine(text);

        //Трішки пограємось, більше практики краще для пам'яті <--------------------------------------------------------------------------------------------------------------

        Console.Write("Enter another string: ");
        StringBuilder newText = new StringBuilder(Console.ReadLine());

        int counter = 0; // Рахуємо кількість пробілів

        for (int i = 0; i < newText.Length; i++)
        {
            if (newText[i] == ' ')
            {
                counter++;
            }
        }

        Console.WriteLine(counter);

        //TODO new massive to indexes of spaces
        int[] indexes = new int[counter];   // Створюємо масив для індексів пробілів

        var tempo = 0; // тимчасова змінна 

        for (int i = 0; i < newText.Length; i++) // цикл для присвоєння значень індексів пробілів в новий масив
        {
            if (newText[i] == ' ')
            {
                indexes[tempo] = i;
                tempo++;               
            }            
        }

        for (int o = 0; o < indexes.Length; o++)  
        {
            Console.Write($"{indexes[o]}  ");      // Виводимо значення масиву з індексами пробілів
        }

        //TODOremove spaces from indexes
        for (int i = indexes.Length-1; i >= 0; i--)
        {
            newText.Remove(indexes[i], 1);      // Прибераємо пробіли
        }

        string res = newText.ToString();    // перетворюємо стрінгбілдер в строку
        Console.WriteLine($"\n{res}");

    }
}