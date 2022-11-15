/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

string PrintNumbers(int num1, int num2)
{
    if (num1 == num2)
        return num1.ToString();
    else
    {
        return PrintNumbers(num1, num2 - 1) + "," + num2;
    }
}

int SumNumbers(int num1, int num2)
{
    if (num1 == 0) return (num2 * (num2 + 1)) / 2;            // Если M равно нулю
            else if (num2 == 0) return (num1 * (num1 + 1)) / 2;       // Если N равно нулю
            else if (num1 == num2) return num1;                       // Если M=N
            else if (num1 < num2) return num2 + SumNumbers(num1, num2 - 1); // Если M<N
            else return num2 + SumNumbers(num1, num2 + 1);            // Если M>N
}


int num1 = GetNumber("введите число M: ");
int num2 = GetNumber("введите число N: ");
Console.WriteLine($"сумма чисел от M до N ({PrintNumbers(num1, num2)}) = {SumNumbers(num1, num2)}");