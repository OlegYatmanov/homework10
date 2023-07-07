using System;
using static System.Console;
Clear();

double InputNum (string message)
{
    Write (message);
    return int.Parse(ReadLine ());
}
double b1 = InputNum ($"Задайте b1: ");
double k1 = InputNum ($"Задайте k1: ");
double b2 = InputNum ($"Задайте b2: ");
double k2 = InputNum ($"Задайте k2: ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

WriteLine ($"Точка пересечения прямых: ({x}, {y})");