using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
class Checking
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Enter you name and surname: ");
        string name = Console.ReadLine();
        name.Trim();

        int counter = 0;

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == ' ')
            {
                counter++;
            }
        }
        if (counter != 1)
        {
            Console.WriteLine("Введіть коректніше: ім'я і прізвище через пробіл. Ніякої самодіяльності");
        }

        if (counter == 1)
        {
            int index = name.IndexOf(' ');

            char first = name[0];
            char second = name[index + 1];

            if (char.IsLower(first))
            {
                first = char.ToUpper(first);
            }

            if (char.IsLower(second))
            {
                second = char.ToUpper(second);
            }

            if (first == second)
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }
        }
    }
}