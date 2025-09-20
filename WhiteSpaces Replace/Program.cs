using System.Diagnostics.Metrics;

class WhiteSpaces
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Enter string: ");
        System.Text.StringBuilder text = new System.Text.StringBuilder(Console.ReadLine());
        
        int counter =0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                counter++;
                text = text.Remove(i, 1);
            }
        }
        Console.WriteLine($"We have deleted {counter} whitespaces.\n{text.ToString()}");        
    }
}