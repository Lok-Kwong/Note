﻿using System;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.Remove("Manu", 'r'));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayalam"));
        Console.Read();
    }
}