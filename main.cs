// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        double fahrenheit;
        double celsius;

        //Input
        Console.WriteLine("This program will convert temperature.");
        Console.WriteLine("");
        Console.Write("Enter fahrenheit: ");
        fahrenheit = float.Parse(Console.ReadLine());

        //Process
        celsius = ((fahrenheit - 32) * 5 / 9);

        //Output
        Console.WriteLine("");
        Console.WriteLine("Celsius: " + (celsius.ToString("0.00") + " °C."));

        Console.WriteLine("\nDone.");
    }
}