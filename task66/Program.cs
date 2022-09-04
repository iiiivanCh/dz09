// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int numberSum = 0;
int numberM = GetNumbersFromUser(1, "Введите число M => 1, M = ", "Ошибка ввода");
int numberN = GetNumbersFromUser(numberM, "Введите число N > M, N = ", "Ошибка ввода");
Console.Clear();
Console.Write($"M = {numberM}; N = {numberN} --> ");
PrintSumNaturalsNambers(numberM, numberN, numberSum);


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

string PrintSumNaturalsNambers(int start, int end, int sum)
{
  if (start == end + 1)
  {
    Console.Write($"{sum}");
    return sum.ToString();
  }
  else
  {
    sum += start;
    return PrintSumNaturalsNambers(start + 1, end, sum);
  }
}

