/* Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.)*/

using static System.Console;
Clear();

WriteLine("Введите первую сторону");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите вторую сторону");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите третью сторону");
int c = Convert.ToInt32(ReadLine());
    if ((a<=0 || b<=0 || c<=0) || (a+b<=c || a+c<=b || c+b<=a))
        {
            WriteLine("Треугольник не существует");
            ReadKey();
            return;
        }
    Write("Треугольник существует и он");
    int max=Math.Max(Math.Max(a, b), c);
        if (max == a)
            {
                a = b;
                b = c;
            }
            else
            if (max == b)
                {
                    b = c;
                }
WriteLine("{0}является прямоугольным",Math.Pow(max,2)==Math.Pow(a,2)+Math.Pow(b,2)?" ":" не ");
ReadKey();

// Код
// string GetNum1(int number)
// {
//     string result="";

//     while(number>0)
//     {
//         result=number%2+result;
//         number/=2;
//     }
//     return result;
// }

// using static System.Console;
// using System.Linq;
// Clear();
// WriteLine("Введите число:");

// int num = int.Parse(ReadLine()!);
// WriteLine(Convert.ToString(num,8));
// WriteLine(GetNum1(num));
// WriteLine(DecToNum(num,8));


// string GetNum1(int number)
// {
//     string result="";

//     while(number>0)
//     {
//         result=number%8+result;
//         number/=8;
//     }
//     return result;
// }

// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }

// *Код по другому
// string DecToNum1(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber%otherSystem;
//         res=nums[ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }



/*Задача 45: Напишите программу, которая будет
создавать копию заданного массива с помощью поэлементного копирования.*/

// using static System.Console;
// using System.Linq;
// Clear();
// WriteLine("Введите число:");

// int[] array1 = new int[10].Select(x=> new Random().Next(0,100)).ToArray();
// int[] array2 = CopyArray(array1);
// WriteLine($"[{String.Join(",", array1)}]");
// WriteLine($"[{String.Join(",", array2)}]");

// int[] CopyArray (int[] arr1)
// {
//     int[] result = new int[arr1.Length]; 
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         result[i] = arr1[i];
//     }
//     return result;
// // }


// /*Задача 44: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

// using static System.Console;
// Clear();

// WriteLine("Введите число:");
// int number = Convert.ToInt32(ReadLine());
// int[] result = Fibonacci(number);
// WriteLine($"[{String.Join(",", result)}]");

// int[] Fibonacci (int n)
// {
//     int[] arr = new int[n];
//     arr[0] = 0;
//     arr[1] = 1;
//     for(int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i-1] + arr[i-2];
//     }
//     return arr;
// }


// Write("Введите число N: ");
// int N = int.Parse(ReadLine());
// WriteLine($"{String.Join(" ", Fibb(N))}");

// int[] Fibb(int NN)
// {
//     int[] Fib = new int[NN];
//     //
//     Fib[0] = 0;
//     Fib[1] = 1;
//     for (int i = 2; i < NN; i++)
//     {
//         Fib[i] = Fib[i - 1] + Fib[i - 2];
//     }
//     return Fib;
// }



/* Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.*/

// int[] Mainmas = { 2, 4, 56, 7, 423, 45, 5 };
// // int[] nums5 = { 1, 2, 3, 5 };
// int[] masCopyArray = CopyMasMethod(Mainmas);

// WriteLine($"{String.Join(" ", masCopyArray)}");
// for (int i = 0; i < masCopyArray.Length; i++)
// {
//     Write($"{masCopyArray[i]} ");
// }
// int[] CopyMasMethod(int[] mas)
// {
//     int[] result = new int[mas.Length];
//     for (int i = 0; i < mas.Length; i++)
//     {
//         result[i] = mas[i];//в masCopy копируем значение из mas, тут все понятно должно быть

//     }
//     return result;
// }
/*Последний пример из семинара*/

// using static System.Console;
// using System.Linq;
// Clear();
// WriteLine("Введите массив через пробел:");

// int count = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray().Where(a=>a%2!=0).Count();

// WriteLine(count);

