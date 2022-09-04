// Задача 68: Напишите программу вычисления функции Аккермана с
//  помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

//Если смотреть Википедию, то в строчке 3 значения аргументов перепутаны

Console.Clear();

uint numberM = GetNumbersFromUser(1, "Введите число M, m = ", "Ошибка ввода");
uint numberN = GetNumbersFromUser(numberM, "Введите число N, n = ", "Ошибка ввода");
Console.Clear();
Console.Write($"M = {numberM}; N = {numberN} --> ");
uint akk = Akkermen(numberM, numberN);
Console.Write($"A(m,n) = {akk}");


uint GetNumbersFromUser(uint limit, string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = uint.TryParse(Console.ReadLine(), out uint userNumber);
    if (isCorrect) return userNumber;
    Console.WriteLine(errorMessage);
  }
}

uint Akkermen(uint m, uint n)
{
  if (m == 0) return n + 1;
  if (m != 0 && n == 0) return Akkermen(m - 1, 1);
  if (m > 0 && n > 0) return Akkermen(m - 1, Akkermen(m, n - 1));
  return Akkermen(m, n);
}