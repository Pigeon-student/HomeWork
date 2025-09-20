class Report
{
    static DateTime buildTime = DateTime.Now;
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Title = "REPORT";

        string hello = String.Empty;

        string dataTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine($"\tReport from {dataTime}\n");


        hello = "Hello user! Enter your name: ";

        Console.Write(hello);
        string name = Console.ReadLine();

        System.Text.StringBuilder userName = new System.Text.StringBuilder(name);

        Console.Write("Change the first letter of your name to number of your age: ");
        string Age = Console.ReadLine();
        char[] userAge = Age.ToCharArray();

        userName.Replace(userName[0], userAge[0]);

        System.Text.StringBuilder text = new System.Text.StringBuilder();

        Console.Write("How much action do you want to discrabe? : ");
        int numb = int.Parse(Console.ReadLine());

        for (int i = 1; i < numb + 1; i++)
        {
            Console.Write($"Type your {i} message: ");
            text = text.Append(Console.ReadLine());
            if (i != numb)
            { 
                text = text.Append(", ");
            }
        }

        text = text.Replace(' ', '_');

        text = text.Remove(5, 3);

        text = text.Insert(3, " ! Glory2Ukraine ! ");

        Console.WriteLine($"\nOk {userName}, here is you day:\n\t{text}.");
    }
}