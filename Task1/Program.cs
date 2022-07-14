// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

Console.Clear();

int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

void Subsequenc(int numberElements, int resault = 0, int countNum = 0)
{
    if (numberElements == 0) return;
    for (int i = 0; countNum < numberElements; i++)
    { 
        countNum = countNum + i; 
        resault = i; 
    } 
    Subsequenc(--numberElements);
    System.Console.Write($"{resault}, ");  
}

int numberElements = Promt("Введите число элементов последовательности => ");
Subsequenc(numberElements);

