// Задача 64: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

int number_M = GetNumbersFromUser(1, "Введите число M => 1, M = ", "Ошибка ввода");
int number_N = GetNumbersFromUser(number_M, "Введите число N > M, N = ", "Ошибка ввода");
Console.Clear();
Console.Write($"M = {number_M}; N = {number_N} --> \"\"");
PrintNaturalsNambers(number_M, number_N);


int GetNumbersFromUser(int limit, string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if (userNumber < limit) isCorrect = false;
    else
      if (isCorrect) return userNumber;
    Console.WriteLine(errorMessage);
  }
}

string PrintNaturalsNambers(int start, int end)
{
  if (start == end + 1)
    return start.ToString();
  else
  {
    if (start == end)
      Console.Write($"{start}\"\"");
    else
      Console.Write($"{start}, ");
    return PrintNaturalsNambers(start + 1, end);
  }
}
