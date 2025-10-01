using System;
using System.Collections.Generic;
class Diary
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        List<string> tasks = new List<string>();

        WriteTextColorBlue("Вітаю і дякую, що користуєтеся нашим записником!" +
            "\n\nВам доступні наступні команди для роботи з текстом:" +
            "\nМожна додавати завдання, просто напишить \"Створити\"" +
            "\nЩоб видаляти, напишіть \"Видалити\"" +
            "\nТакож вставити завдання за допомогою команди \"Вставити\"" +
            "\nПоказати всі завдання в записнику - \"Відобразити\"" +
            "\nАбо ж очистити записник за допомогою \"Очистити\"" +
            "\nДля завершення роботи просто введіть \"Вихід\"!" +
            "\n\nЗ чого Ви б хотіли розпочати?\n");

        bool isUserTired = false;

        while (!isUserTired)
        {
            WriteTextColorBlue("\nВведіть команду: ");

            string userComand = Console.ReadLine().ToLower();

            switch (userComand)
            {
                case "створити":
                    AddNewTask(tasks);
                    break;
                case "видалити":
                    RemoveTask(tasks);
                    break;
                case "вставити":
                    InsertTask(tasks);
                    break;
                case "очистити":
                    ClearTasks(tasks);
                    break;
                case "відобразити":
                    ShowAllTasks(tasks);
                    break;
                case "exit":
                case "вихід":
                    isUserTired = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nДякую, що скористалися нашим записником! Гарного дня!");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНевідома команда! Спробуйте ще раз");
                    Console.ResetColor();
                    break;
            }
        }

        //METHODs

        static void AddNewTask(List<string> tasks)
        {
            var taskNumber = tasks.Count + 1;

            WriteTextColorBlue($"\nНапишіть заголовок #{taskNumber}: ");

            string header = Console.ReadLine().Trim();

            WriteTextColorBlue("Додайте опис завдання: ");

            tasks.Add($"Завдання #{taskNumber}:\n{header}: {Console.ReadLine().Trim()}");
        }

        static void RemoveTask(List<string> tasks) // Видаляє завдання за номером
        {
            WriteTextColorBlue("\nДля ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ВИДАЛЕННЯ ");

            WriteTextColorBlue("завдання введіть його номер: ");

            var input = Console.ReadLine();
            var taskNumber = -1;
            if (int.TryParse(input, out taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Завдання #{taskNumber} видалено!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Невірний номер завдання!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Wronf Format");
            }
        }

        static void InsertTask(List<string> tasks)
        {
            WriteTextColorBlue("\nКуди вставити? Введіть номер: ");

            var input = Console.ReadLine();

            if (int.TryParse(input, out int position) && position > 0 && position < tasks.Count + 1)
            {
                WriteTextColorBlue("\nНапишіть заголовок: ");

                string header = Console.ReadLine().Trim(); 

                WriteTextColorBlue($"Запишіть нове завдання: ");

                tasks.Insert(position-1, $"Завдання #{position} (нове):\n{header}: {Console.ReadLine().Trim()}");
            }
            else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неможна сюди вставляти!");
                Console.ResetColor();
            }

        }

        static void ClearTasks(List<string> tasks) // Очищає весь список завдань
        {
            WriteTextColorBlue("\nВи впевнені що хочете  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ВИДАЛИТИ ");
            //Console.ResetColor();
            WriteTextColorBlue("всі завдання? : ");

            var input = Console.ReadLine().ToLower();

            if (input == "yes" || input == "так")
            {
                tasks.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВсі завдання видаленo");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nОперацію скасовано!");
                Console.ResetColor();
            }
        }

        static void ShowAllTasks(List<string> tasks)
        {
            WriteTextColorBlue("\nОсь всі завдання:\n");

            if (tasks.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nЗаписник порожній!\n");
                Console.ResetColor();
            }
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        static void DoneTask(List<string> tasks)
        {
            WriteTextColorBlue("\nЯке завдання Ви вже зробили? : ");

            var input = Console.ReadLine();
            var taskNumber = -1;
            if (int.TryParse(input, out taskNumber))
            {
                tasks.Insert(taskNumber - 1, " \u2714  " + tasks[taskNumber - 1]);
            }
            else
            {
                Console.WriteLine("Невірний формат");
            }
        }

        static void WriteTextColorBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(text);
            Console.ResetColor();
        }

    }
}
