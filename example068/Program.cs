/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

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

int Akkermanrec(int m, int n)
{
        if (m == 0)
        return n + 1;
        else if (n == 0 && m > 0)
        return Akkermanrec(m - 1, 1);
        else
        return Akkermanrec(m - 1, Akkermanrec(m, n - 1));
}
int m = GetNaturalNumber("Введите натуральное число: ");
int n = GetNaturalNumber("Введите натуральное число: ");
Console.WriteLine(Akkermanrec(m, n));
