// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

void Subsequenc(int numberElements, int i = 1)
{
    if (numberElements <= 0) return;
    System.Console.Write($"{i}, ");
    Subsequenc(numberElements - 1, i + 1);
    
}

int numberElements = Promt("Введите число элементов последовательности => ");
Subsequenc(numberElements);

