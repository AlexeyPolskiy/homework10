// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

int Recursion(int numberM, int numberN)
{
    // Базовый случай
    if (numberM == 0)
    {
        return numberN + 1;
    } // Шаг рекурсии / рекурсивное условие
    else
    if (numberN == 0 && numberM > 0)
    {
        return Recursion(numberM - 1, 1);
    } // Шаг рекурсии / рекурсивное условие
    else
    {
        return Recursion(numberM - 1, Recursion(numberM, numberN - 1));
    }
}

int numberM = Promt("Введите не отрицательное число M => ");
int numberN = Promt("Введите не отрицательное число N => ");

System.Console.WriteLine(Recursion(numberM, numberN));
