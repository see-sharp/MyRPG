﻿using System;
using System.Collections.Generic;

public static class Extensions
{
    public static void EchoWriteLine(this string strValue)
    {
        Console.WriteLine(strValue);
    }
    public static void EchoWrite(this string strValue)
    {
        Console.Write(strValue);
    }
    public static void Position(this string strValue, int xPosition = 0, int yPosition = 0, string color = "Grey")
    {
        string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

        foreach (string colorName in colorNames)
            if (colorName == color)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                break;
            }
        Console.SetCursorPosition(xPosition, yPosition);
        Console.Write(strValue);
    }
    public static void PositionEllerCW(this string strValue, int xPosition = 0, int yPosition = 0)
    {
        Console.SetCursorPosition(xPosition, yPosition);
        Console.Write(strValue);
    }
}

