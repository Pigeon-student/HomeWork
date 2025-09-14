using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ZeroCrossGame
{
    class Game
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello, let's play a game!");

            Console.Write("\nWhat is 1st player name? Tell me: ");
            string firstPlayerName = Console.ReadLine();
            Console.Write("What is 2nd player name? Sign it: ");
            string secondPlayerName = Console.ReadLine();


            Console.WriteLine("\n\tLet's start!\n\n");

            // VARIABLES
            string zero = "O";
            string cross = "X";

            int userChoise = 0;


            const int RAWS = 3;
            const int COLLS = 3;

            int counter = 0;
            const int TRY = 9;

            bool isPlayerOne = true;
            bool isWin = false;

            // START

            string[,] field = new string[RAWS, COLLS]
                {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
                };

            for (int i = 0; i < RAWS; i++)
            {
                for (int j = 0; j < COLLS; j++)
                {
                    Console.Write($"{field[i, j]}");
                    if (j < COLLS - 1) Console.Write(" | ");
                }
                Console.WriteLine();

                if (i < RAWS - 1)
                {
                    Console.WriteLine("----------");
                }
            }

            // INSANE START

            while (counter < TRY && !isWin)
            {



                if (isPlayerOne)
                {

                    Console.Write($"\nLet's {firstPlayerName} choose number to put {cross} in it: ");
                    userChoise = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (userChoise)
                    {
                        case 1:

                            if (field[0, 0] != cross && field[0, 0] != zero)
                            {
                                field[0, 0] = cross;
                            }
                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 2:

                            if (field[0, 1] != cross && field[0, 1] != zero)
                            {
                                field[0, 1] = cross;
                            }
                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                
                            }
                            break;

                        case 3:

                            if (field[0, 2] != cross && field[0, 2] != zero)
                            {
                                field[0, 2] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }

                            break;

                        case 4:

                            if (field[1, 0] != cross && field[1, 0] != zero)
                            {
                                field[1, 0] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 5:

                            if (field[1, 1] != cross && field[1, 1] != zero)
                            {
                                field[1, 1] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 6:

                            if (field[1, 2] != cross && field[1, 2] != zero)
                            {
                                field[1, 2] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 7:

                            if (field[2, 0] != cross && field[2, 0] != zero)
                            {
                                field[2, 0] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 8:

                            if (field[2, 1] != cross && field[2, 1] != zero)
                            {
                                field[2, 1] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 9:

                            if (field[2, 2] != cross && field[2, 2] != zero)
                            {
                                field[2, 2] = cross;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;
                    }

                    isPlayerOne = false;
                    counter++;
                    Console.WriteLine();
                }


                else 
                {
                    Console.Write($"\nLet's {secondPlayerName} choose number to put {zero} in it: ");
                    userChoise = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (userChoise)
                    {
                        case 1:

                            if (field[0, 0] != cross && field[0, 0] != zero)
                            {
                                field[0, 0] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }

                            break;

                        case 2:

                            if (field[0, 1] != cross && field[0, 1] != zero)
                            {
                                field[0, 1] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 3:

                            if (field[0, 2] != cross && field[0, 2] != zero)
                            {
                                field[0, 2] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }

                            break;

                        case 4:

                            if (field[1, 0] != cross && field[1, 0] != zero)
                            {
                                field[1, 0] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }

                            break;

                        case 5:

                            if (field[1, 1] != cross && field[1, 1] != zero)
                            {
                                field[1, 1] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 6:

                            if (field[1, 2] != cross && field[1, 2] != zero)
                            {
                                field[1, 2] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 7:

                            if (field[2, 0] != cross && field[2, 0] != zero)
                            {
                                field[2, 0] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 8:

                            if (field[2, 1] != cross && field[2, 1] != zero)
                            {
                                field[2, 1] = zero;

                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                        case 9:

                            if (field[2, 2] != cross && field[2, 2] != zero)
                            {
                                field[2, 2] = zero;
                            }

                            else
                            {
                                Console.WriteLine("This index is full. Choose another one.");
                                counter--;
                            }
                            break;

                    }

                    isPlayerOne = true;
                    counter++;
                    Console.WriteLine();
                }

                // Перевірка по рядках
                for (int raw = 0; raw < RAWS; raw++)
                {
                    if (field[raw, 0] == cross &&
                        field[raw, 1] == cross &&
                        field[raw, 2] == cross)
                    {
                        Console.WriteLine($"\tGame over! {firstPlayerName} is win!-\n");
                        isWin = true;// GOTO
                        break;  
                    }

                    if (field[raw, 0] == zero &&
                        field[raw, 1] == zero &&
                        field[raw, 2] == zero)
                    {
                        Console.WriteLine($"\tGame over! {secondPlayerName} is win!-\n");
                        isWin = true;// GOTO
                        break; ;                       
                    }                    
                }

                // Перевірка по стовпчиках

                for (int coll = 0; coll < COLLS; coll++)
                {
                    if (field[0, coll] == cross &&
                        field[1, coll] == cross &&
                        field[2, coll] == cross)
                    {
                        Console.WriteLine($"\tGame over! {firstPlayerName} is win!|\n");
                        isWin = true;// GOTO
                        break;
                    }

                    if (field[0, coll] == zero &&
                        field[1, coll] == zero &&
                        field[2, coll] == zero)
                    {
                        Console.WriteLine($"\tGame over! {secondPlayerName} is win!|\n");
                        isWin = true;// GOTO
                        break;
                    }

                }



                // Перевірка по діагоналях

                for (int diag = 0; diag < COLLS; diag++)
                {
                    if (field[0, 0] == cross &&
                        field[1, 1] == cross &&
                        field[2, 2] == cross)
                    {
                        Console.WriteLine($"\tGame over! {firstPlayerName} is win! > \n");
                        isWin = true; // GOTO 
                        break;

                    }

                    if (field[0, 0] == zero &&
                       field[1, 1] == zero &&
                       field[2, 2] == zero)
                    {
                        Console.WriteLine($"\tGame over! {secondPlayerName} is win! > \n");
                        isWin = true; // GOTO 
                        break;

                    }

                }

                for (int diag = 0; diag < COLLS; diag++)
                {
                    if (field[0, 2] == cross &&
                        field[1, 1] == cross &&
                        field[2, 0] == cross)
                    {
                        Console.WriteLine($"\tGame over! {firstPlayerName} is win! /\n");
                        isWin = true; // GOTO 
                        break;

                    }

                    if (field[0, 2] == zero &&
                        field[1, 1] == zero &&
                        field[2, 0] == zero)
                    {
                        Console.WriteLine($"\tGame over! {secondPlayerName} is win! /\n");
                        isWin = true; // GOTO 
                        break;

                    }

                }

                for (int i = 0; i < RAWS; i++)
                {
                    // рядок із символами
                    for (int j = 0; j < COLLS; j++)
                    {
                        Console.Write($"{field[i, j]}");

                        if (j < COLLS - 1)             // AI hint
                        {
                            Console.Write(" | ");
                        }
                    }
                    Console.WriteLine();

                    // розділювач між рядками           // AI hint
                    if (i < RAWS - 1)
                    {
                        Console.WriteLine("----------");
                    }

                }
            }

        //End:
            if (counter == TRY)
            {
                Console.WriteLine("\n\tGame Over! It's a draw!");
            }
        }
    }
}




