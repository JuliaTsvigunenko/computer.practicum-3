using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Компьютерный практикум №3

            //Вариант 6 (задача №6)
            //Запросить у пользователя 5 слов, после чего вывести эти слова, каждое на новой строке. Использовать 5 функции вывода.

            Console.Title = "Программа №5 (Цвигуненко Юлия)";
            Console.WriteLine("Ввести 5 слов");
            Console.WriteLine("Введите первое слово:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово:");
            string word2 = Console.ReadLine();
            Console.WriteLine("Введите третье слово:");
            string word3 = Console.ReadLine();
            Console.WriteLine("Введите четвертое слово:");
            string word4 = Console.ReadLine();
            Console.WriteLine("Введите пятое слово:");
            string word5 = Console.ReadLine();
            Console.WriteLine($"{word1}\n{word2}");
            Console.WriteLine($"{word3}");
            Console.WriteLine($"{word4}\n{word5}");
            Console.WriteLine($"{word2}\n{word3}\n{word4}");
            Console.WriteLine(word5);
            Console.ReadKey();
        }
    }
}
