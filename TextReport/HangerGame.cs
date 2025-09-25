using System;

enum Dificalt : byte
{
    EASY = 1,
    MEDIUM,
    HARD,
    NIGHTMARE
}
enum Classes : byte
{
    paladin,
    demonhunter,
    mage,
    shaman,
    ranger,
    priest,
    warlock,
    nighthunter,
    druid,
    rogue,
    deathknigh,
    warrior
}
enum Heroes : byte
{
    Arthas,
    Illidan,
    Jaina,
    Thrall,
    Sylvanas,
    Anduin,
    Guldan,
    Tyrande,
    Malfurion,
    Skwizgaar,
    Mogreine,
    Bolvar
}

class Program
{
    static void Main()
    {
        //Console.InputEncoding = System.Text.Encoding.UTF8;
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random random = new Random();
        var randomNumber = random.Next(1, 12);

        Heroes chosenHero = (Heroes)randomNumber;
        Classes chosenClass = (Classes)randomNumber;
        string word = chosenClass.ToString();

        char[] misteryWord = new char[word.Length];

        for (int i = 0; i < misteryWord.Length; i++)
        {
            misteryWord[i] = '_';
        }

        var attemps = word.Length;
        var counter = 0;

        Console.Write($"\tHello player! My name is John Root! \n\nChoose level of dificalt" +
            $" (1, 2, 3, 4) : ");
        var chosenDificalt = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"\n\tNice! You choose {(Dificalt)chosenDificalt} level!\n");

        switch ((Dificalt)chosenDificalt)
        {
            case Dificalt.EASY:
                attemps = word.Length + 3;
                break;
            case Dificalt.MEDIUM:
                attemps = word.Length + 1;
                break;
            case Dificalt.HARD:
                attemps = word.Length;
                break;
            case Dificalt.NIGHTMARE:
                attemps = word.Length - 1;
                break;
            default:
                Console.WriteLine("You choose wrong dificalt. Try again.");
                break;
        }

        Console.WriteLine($"\n\tGuess who {chosenHero} is? It's {word.Length} letters!");

        while (counter < attemps)
        {
            Console.Write($"\nEnter a letter (you have {attemps - counter} attemps) : ");
            char letter = Char.ToLower(Convert.ToChar(Console.ReadLine()));

            if (misteryWord.Contains(letter))
            {
                Console.WriteLine($"You already found the letter '{letter}'. Try another one.");
            }
            else if (word.Contains(letter))
            {
                for (int i = 0; i < misteryWord.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        misteryWord[i] = letter;
                    }
                }
                Console.Write(misteryWord);
            }
            else
            {
                counter++;
                Console.WriteLine($"The letter '{letter}' is NOT in the word. You have {attemps - counter} try");

                if (counter == attemps)
                {
                    Console.WriteLine($"\n\n\tYou loose. The word is - \"{word}\". Good bye!\n\n\n");
                }
            }

            if (!misteryWord.Contains('_'))
            {
                Console.WriteLine($"\n\n\tCongratulations! You found the word - \"{word}\". Good bye!\n\n\n");
                break;
            }
        }
    }
}