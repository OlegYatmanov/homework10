using System;
using static System.Console;
Clear();

Write($"Введи число М(количество чисел): ");
int m = int.Parse(ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Write($"Введи {i+1} число: ");
    massiveNumbers[i] = int.Parse(ReadLine());
  }
}
int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(m);
WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");