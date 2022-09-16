// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// int NaturalNumbers(int M, int N)
// {
//     if (M < N)
//     {
//         Console.Write($"{M}, ");
//         return NaturalNumbers(M + 1, N);  
//     } 
//     else return N;
// }
// Console.WriteLine(NaturalNumbers(1, 9));

/*******************************************************************************************************************************************/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// int SumNumbers(int M, int N)
// {
//     if (M < N) return M + SumNumbers(M + 1, N);
//     else return M;  
// }
// Console.WriteLine($"Cумма натруальных элементов между введенными числами равна {SumNumbers(1, 5)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

            
int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0 && m > 0) return Akkerman(m - 1, 1);
        if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
        return Akkerman(m,n);
    }

Console.WriteLine(Akkerman(5,0));