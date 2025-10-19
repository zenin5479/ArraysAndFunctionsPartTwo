using System;

// Задача: Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N
// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// Задача: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Задача: Напишите программу, на ввод подается номер четверти, создаются N случайных точек в этой четверти
// Определить оптимальный маршрут торгового представителя, который выезжает из центра координат
// Задача: Даны 4 точки A (x1,y1), B (x2,y2), C (x3, y3), D (x4, y4). Проверить пересекаются ли вектора AB и CD.
// Определить в какой честверти лежит точка пересечения векторов

namespace ArraysAndFunctionsPartTwo
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("-----------------------------");
         Console.WriteLine("Таблица кубов чисел от 1 до N");
         Console.WriteLine("-----------------------------");
         Random randomized = new Random();
         int date = randomized.Next(1, 20);
         Console.WriteLine("N = " + date);
         int countcub = 1;
         while (countcub <= date)
         {
            string text = "--------+--------\n";
            text = text + "|  " + countcub + "\t|  " + countcub * countcub * countcub + "\t|";
            Console.WriteLine(text);
            countcub++;
         }

         Console.WriteLine("-----------------------------------------------------------");
         Console.WriteLine("Нахождение расстояния между двумя точками в 3D пространстве");
         Console.WriteLine("-----------------------------------------------------------");
         int aX = randomized.Next(-10, 10);
         int aY = randomized.Next(-10, 10);
         int aZ = randomized.Next(-10, 10);
         int bX = randomized.Next(-10, 10);
         int bY = randomized.Next(-10, 10);
         int bZ = randomized.Next(-10, 10);

         // Формула длины отрезка 3D = SQRT((aX-bX)^2 + (aY-bY)^2 + (aZ-bZ)^2 )
         Console.WriteLine("Точка А -  [" + aX + ", " + aY + ", " + aZ + "]");
         Console.WriteLine("Точка B -  [" + bX + ", " + bY + ", " + bZ + "]");
         Console.WriteLine("Длина отрезка AB в 3D = " + Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ)));

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант с числовым форматом");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         int figure = Convert.ToInt32(Console.ReadLine());
         // Метод для переворачивания целого числа
         int Inversions(int numeral)
         {
            int i = numeral;
            if (i < 0)
            {
               numeral = -1 * numeral;
            }

            int numeralone = 0;
            while (numeral > 0)
            {
               // Находим остаток - последнюю цифру исходного числа
               int digit = numeral % 10;
               // Удаляем последнюю цифру исходного числа (уменьшаем разрядность)
               numeral /= 10;
               // Формируем новое  второе число (увеличиваем разрядность)
               numeralone *= 10;
               // Добавляем цифру в разряд втрого числа
               numeralone += digit;
            }

            if (i < 0)
            {
               return -1 * numeralone;
            }

            return numeralone;
         }

         int numeraltwo = Inversions(figure);
         if (figure == numeraltwo) Console.WriteLine("Число: " + figure + " - является палиндромом");
         else Console.WriteLine("Число: " + figure + " - не является палиндромом");

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант 1 с форматом строка");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         string paragraph = Console.ReadLine();
         // Метод для переворачивания строки
         void InversionsString(string fragment)
         {
            int lines = fragment.Length;
            char[] charone = fragment.ToCharArray();
            char[] chartwo = new char[lines];
            int p = 0;
            int q = lines;
            while (p < lines)
            {
               q -= 1;
               chartwo[q] = charone[p];
               p++;
            }

            int count = 0;
            int t = 0;
            while (t < lines)
            {
               if (chartwo[t] == charone[t])
               {
                  count++;
               }

               t++;
            }

            if (count == lines)
            {
               Console.WriteLine("Запись: " + fragment + " - является палиндромом");
            }
            else
            {
               Console.WriteLine("Запись: " + fragment + " - не является палиндромом");
            }
         }

         InversionsString(paragraph);

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант 2 с форматом строка");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         string palindromeone = Console.ReadLine();
         Palindrom(palindromeone);
         void Palindrom(string digits)
         {
            if (digits[0] == digits[4] && digits[1] == digits[3])
            {
               Console.WriteLine($"Число {digits} является полиндромом");
            }
            else
            {
               Console.WriteLine($"Число {digits} не является полиндромом");
            }
         }

         Console.WriteLine("--------------------------------------------------------------------------------------------");
         Console.WriteLine("Определить оптимальный маршрут торгового представителя, который выезжает из центра координат");
         Console.WriteLine("--------------------------------------------------------------------------------------------");
         Console.WriteLine("Введите номер четверти: ");
         int numberChetv = Convert.ToInt32(Console.ReadLine());
         bool selector = true;
         // Расчета мультипликатора для задания точек для определенной четверти
         int xMult = 0; int yMult = 0;
         while (selector)
         {
            if (numberChetv == 1)
            {
               xMult = 1; yMult = 1;
               selector = false;
            }
            else if (numberChetv == 2)
            {
               xMult = -1; yMult = 1;
               selector = false;
            }
            else if (numberChetv == 3)
            {
               xMult = -1; yMult = -1;
               selector = false;
            }
            else if (numberChetv == 4)
            {
               xMult = 1; yMult = -1;
               selector = false;
            }
            else
            {
               Console.WriteLine("Введите правильный номер четверти: ");
               numberChetv = Convert.ToInt32(Console.ReadLine());
            }
         }

         Console.WriteLine("Введите количество точек: ");
         int numberPoint = Convert.ToInt32(Console.ReadLine());
         Random randPoint = new Random();
         // Инициализация массива всех точек по х координате
         int[] arrayX = new int[numberPoint];
         // Инициализация массива всех точек по Y координате
         int[] arrayY = new int[numberPoint];
         // Инициализация массива всех точек по х координате
         int[] arrayXInput = new int[numberPoint];
         // Инициализация массива расстояний от центра до каждой точки
         int[] arrayYInput = new int[numberPoint];
         // Количество элементов массива (точек)
         double[] arrayDistance = new double[numberPoint];
         int distance = arrayX.Length;
         // Метод MethodFillArray для заполнения массива случайными числами заданной четверти
         void MethodFillArray(int[] array, int mult)
         {
            int size = array.Length;
            int record = 0;
            while (record < size)
            {
               array[record] = mult * randPoint.Next(1, 10);
               record++;
            }
         }

         // Заполнение массива координатами Х соответствующей четверти
         MethodFillArray(arrayX, xMult);
         // Заполнение массива координатами Y соответствующей четверти
         MethodFillArray(arrayY, yMult);
         // Массив для вывода первоначальных значений точек
         int rx = 0;
         while (rx < distance)
         {
            arrayXInput[rx] = arrayX[rx];
            arrayYInput[rx] = arrayY[rx];
            rx++;
         }

         // Заполнение массива расстояний от центра до каждой точки
         int register = 0;
         while (register < distance)
         {
            arrayDistance[register] = Math.Sqrt(arrayX[register] * arrayX[register] + arrayY[register] * arrayY[register]);
            register++;
         }

         // Сортировка элементов массива от меньшего значения к большему
         int i = 0;
         while (i < distance)
         {
            int j = 0;
            while (j < distance - 1)
            {
               if (arrayDistance[j] > arrayDistance[j + 1])
               {
                  double tD = arrayDistance[j + 1];
                  int tX = arrayX[j + 1];
                  int tY = arrayY[j + 1];
                  arrayDistance[j + 1] = arrayDistance[j];
                  arrayX[j + 1] = arrayX[j];
                  arrayY[j + 1] = arrayY[j];
                  arrayDistance[j] = tD;
                  arrayX[j] = tX;
                  arrayY[j] = tY;
               }

               j++;
            }

            i++;
         }

         Console.WriteLine("|        Ввод\t\t|    Построение пути\t| ");
         Console.WriteLine("| Точка\t|  Координата\t|  Точка    Расстояние\t|"); //

         register = 0;

         while (register < distance)
         {
            // 4 знака
            string score = string.Format("{0:f4}", arrayDistance[register]);
            // 4 знака
            //string score = arrayDistance[register].ToString("F4");
            // 4 знака + разделители
            //string score = arrayDistance[register].ToString("N4");
            Console.WriteLine("|  " + register + "\t|  [" + arrayXInput[register] + "; " + arrayYInput[register] +
                              "]   " + "\t|  [" + arrayX[register] + "; " + arrayY[register] + "]" + " = " + score + "\t|");
            register++;
         }

         Console.WriteLine("--------------------------------------");
         Console.WriteLine("Определение точки пересечения векторов");
         Console.WriteLine("--------------------------------------");
         Random randomline = new Random();
         double xA = randomline.Next(-10, 10);
         double yA = randomline.Next(-10, 10);
         double xB = randomline.Next(-10, 10);
         double yB = randomline.Next(-10, 10);
         double xC = randomline.Next(-10, 10);
         double yC = randomline.Next(-10, 10);
         double xD = randomline.Next(-10, 10);
         double yD = randomline.Next(-10, 10);

         double ax, ay, bx, by, cx, cy;
         double y = 0, x = 0;
         ax = yA - yB;
         bx = xB - xA;
         cx = xA * yB - xB * yA;
         ay = yC - yD;
         by = xD - xC;
         cy = xC * yD - xD * yC;

         if ((bx * ay - by * ax) != 0)
         {
            y = (cy * ax - cx * ay) / (bx * ay - by * ax);
            x = (-cx - bx * y) / ax;
         }

         // Метод  определения максимального числа из двух
         double MethodMax(double caseone, double casetwo)
         {
            double result = caseone;
            if (casetwo > result)
            {
               result = casetwo;
            }

            return result;
         }

         // Метод определения минимального числа из двух
         double MethodMin(double proofone, double prooftwo)
         {
            double score = proofone;
            if (prooftwo < score)
            {
               score = prooftwo;
            }

            return score;
         }

         Console.WriteLine("AB:  A = [" + xA + ", " + yA + "];  " + "B = [" + xB + ", " + yB + "];  и   CD:  " +
                           "C = [" + xC + ", " + yC + "];  " + "D = [" + xD + ", " + yD + "];  ");
         if (x >= MethodMin(xA, xB) & x <= MethodMax(xA, xB) & y >= MethodMin(yA, yB) & y <= MethodMax(yA, yB))
         {
            Console.WriteLine("Есть точка пересечения:  [x =" + x + ";  y=" + y + "]");
            if (x > 0 & y > 0)
            {
               Console.WriteLine("Точка пересечения в 1 четверти");
            }
            else if (x < 0 & y > 0)
            {
               Console.WriteLine("Точка пересечения во 2 четверти");
            }
            else if (x > 0 & y < 0)
            {
               Console.WriteLine("Точка пересечения в 4 четверти");
            }
         }
         else
         {
            Console.WriteLine("Точки пересечения нет");
         }
         if (bx * ay - by * ax == 0)
         {
            Console.WriteLine("Отрезки параллельны");
         }

         Console.ReadKey();
      }
   }
}