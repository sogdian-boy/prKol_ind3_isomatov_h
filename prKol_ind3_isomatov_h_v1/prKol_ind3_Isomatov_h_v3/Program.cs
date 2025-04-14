using System;
using System.IO;
namespace prKol_ind3_Isomatov_h_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a;
            Vector b;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nВведите название файла(без расширения):");
                    string file = Console.ReadLine()+".txt";
                    if (File.Exists(file))
                    {
                        string[] Coordinates = File.ReadAllLines(file);
                        bool correctB = true;
                        string coorA = Coordinates[0];
                        bool correct = Vector.isCoordinate(coorA);
                        if (correct)
                        {
                            a = new Vector(coorA);
                            Console.WriteLine($"Вектор а = {a.FullVectorCoordinate()}");
                            string coorB = Coordinates[1];
                            correctB = Vector.isCoordinate(coorB);
                            if (correctB)
                            {
                                b = new Vector(coorB);
                                Console.WriteLine($"Вектор b = {b.FullVectorCoordinate()}");
                                bool ON = true;
                                while (ON)
                                {
                                    Console.WriteLine($"\na = {a.FullVectorCoordinate()}\nb = {b.FullVectorCoordinate()}\nВыберите действие\n1. Сложить вектора\n2. Вычитание векторов\n3. Скалярное произведение векторов\n4. Длины векторов\n5. Косинус угла между векторами \n\n6. Выход");
                                    int choice = int.Parse(Console.ReadLine());
                                    switch (choice)
                                    {
                                        case 1: Console.WriteLine($"Результат сложения = " + (a.Plus(b).FullVectorCoordinate())); break;
                                        case 2: Console.WriteLine($"Результат вычитания = " + (a.Minus(b).FullVectorCoordinate())); break;
                                        case 3: Console.WriteLine($"Скалярное произведение векторов = " + (a.Multiply(b))); break;
                                        case 4: Console.WriteLine($"Длины векторов:  \na = {a.Length()}\nb = {b.Length()}"); break;
                                        case 5: Console.WriteLine($"Косинус угла между векторами = {a.Multiply(b) / (a.Length() * b.Length())}"); break;
                                        case 6: Console.Clear(); ON = false; break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: координата задана неправильно");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: координата задана неправильно");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Такого файла не существует!");
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка: Неверный формат данных");
                }
            }
        }
    }
}