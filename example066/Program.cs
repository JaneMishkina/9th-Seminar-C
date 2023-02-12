/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

int SumRec (int m, int n)
{
    if (n==m) return m;
    else return n + SumRec (m, n-1);
}

int m = GetNaturalNumber("Введите натуральное число: ");
int n = GetNaturalNumber("Введите натуральное число: ");
Console.WriteLine(SumRec(m, n));
