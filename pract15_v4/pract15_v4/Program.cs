using pract15_v4;
using System.Collections;
try
{
    ArrayList storage = new ArrayList();
    Random rnd = new Random();
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
            OneDemensionalArray arr = new OneDemensionalArray(n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
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
                ((OneDemensionalArray)storage[num - 1]).Multiply(m);
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
                OneDemensionalArray a = (OneDemensionalArray)storage[num1 - 1];
                OneDemensionalArray b = (OneDemensionalArray)storage[num2 - 1];

                OneDemensionalArray res = (choice == "3")
                    ? OneDemensionalArray.Sum(a, b)
                    : OneDemensionalArray.Sub(a, b);

                Console.Write("Результат: ");
                res.PrintAll();
            }
            else Console.WriteLine("Неверные номера!");
        }
        else if (choice == "5")
        {
            foreach (OneDemensionalArray a in storage) a.PrintAll();
        }
        else if (choice == "6")
        {
            if (storage.Count == 0) { Console.WriteLine("Список пуст!"); continue; }

            Console.Write($"Номер массива (1-{storage.Count}): ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num <= storage.Count)
            {
                Console.Write($"Введите индекс (0-{((OneDemensionalArray)storage[num - 1]).Length - 1}): ");
                int ind = int.Parse(Console.ReadLine());

                if (((OneDemensionalArray)storage[num - 1]).Search(ind, out int item))
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