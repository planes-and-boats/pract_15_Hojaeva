using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using pract15_4;
namespace pract15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList storage = new ArrayList();
                while (true)
                {
                    Console.WriteLine($"\n--- МЕНЮ (Всего массивов: {storage.Count}) ---");
                    Console.WriteLine("\n1. Создать массив\n2. Умножить на число\n3. Сложить массивы\n4. Вычесть массивы\n5. Показать все\n6. Найти элемент\n0. Выход");
                    Console.Write("Выберите действие: ");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.Write("Размер: ");
                        int n = int.Parse(Console.ReadLine());
                        Array arr = new Array(n);
                        arr.FullArray();
                        storage.Add(arr);
                        Console.WriteLine("Массив создан и заполнен случайными числами.");
                    }
                    else if (choice == "2")
                    {
                        if (storage.Count == 0) { Console.WriteLine("Список пуст!"); continue; }

                        int num;
                        if (storage.Count == 1)
                        {
                            num = 1;
                        }
                        else
                        {
                            Console.Write($"Выберите номер массива (1-{storage.Count}): ");
                            num = int.Parse(Console.ReadLine());
                        }
                        if (num > 0 && num <= storage.Count)
                        {
                            Console.Write("Множитель: ");
                            int m = int.Parse(Console.ReadLine());
                            ((Array)storage[num - 1]).Multiply(m);
                            Console.WriteLine("Массив изменен.");
                        }
                        else Console.WriteLine("Неверный номер!");
                    }
                    else if (choice == "3" || choice == "4")
                    {
                        if (storage.Count < 2) { Console.WriteLine("Нужно минимум 2 массива!"); continue; }
                        Console.Write($"Выберите номер массива (1-{storage.Count}): ");
                        Console.Write("Номер массива 1: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Номер массива 2: ");
                        int num2 = int.Parse(Console.ReadLine());

                        if (num1 > 0 && num1 <= storage.Count && num2 > 0 && num2 <= storage.Count)
                        {
                            Array a = (Array)storage[num1 - 1];
                            Array b = (Array)storage[num2 - 1];

                            Array res = (choice == "3")
                                ? Array.Sum(a, b)
                                : Array.Sub(a, b);

                            Console.Write("Результат: ");
                            res.PrintAll();
                        }
                        else Console.WriteLine("Неверные номера!");
                    }
                    else if (choice == "5")
                    {
                        foreach (Array a in storage) a.PrintAll();
                    }
                    else if (choice == "6")
                    {
                        if (storage.Count == 0) { Console.WriteLine("Список пуст!"); continue; }

                        Console.Write($"Номер массива (1-{storage.Count}): ");
                        int num = int.Parse(Console.ReadLine());

                        if (num > 0 && num <= storage.Count)
                        {
                            Console.Write($"Введите индекс (0-{((Array)storage[num - 1]).Length - 1}): ");
                            int ind = int.Parse(Console.ReadLine());

                            if (((Array)storage[num - 1]).Search(ind, out int item))
                                Console.WriteLine("Элемент: " + item);
                            else
                                Console.WriteLine("Индекс вне диапазона!");
                        }
                    }
                    else if (choice == "0") break;
                }
            }
            catch
            {
                Console.WriteLine("Неверный формат данных!");
            }
        }
    }
}
