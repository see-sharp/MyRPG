using System;
using System.Collections.Generic;
using System.Threading;

class Graphics
{
    // Properties
    public static string shortLine = new string(' ', 47);
    public static string fillEmptyItems = new string(' ', 22);
    public static string fillEmptyEgenskaper = new string(' ', 20);
    public static string fillBattleLine3020 = new string(' ', 79);
    public static string fillMenuInBattle = new string(' ', 10);
    public static bool printArea0 = false;
    public static bool printArea1 = true; //A
    public static bool printArea2 = true; //B
    public static bool printArea3 = true; //C
    public static bool printArea4 = true;//D
    public static bool printArea5 = true;//E
    public static bool printArea6 = true;//F
    public static bool printArea7 = true;//G
    public static bool printArea8 = true;//H
    public static bool printArea9 = true;//I
    public static bool printArea10 = true;//J
    public static bool printArea11 = true;//K
    public static bool printArea12 = true; //L


    //////////// PrintArea 13-15 används inte
    public static bool printArea13 = false;
    public static bool printArea14 = false;
    public static bool printArea15 = false;
    // Constructor
    
    // Methods
    public static void EnemyAttack(Enemies e)
    {
        string color = " ";

        if (e.Element == "inget")
            color = "Yellow";
        else if (e.Element == "eld")
            color = "Red";
        else if (e.Element == "is")
            color = "Blue";

        int UN = 63; // Höger och vänster
        int HV = 5; // Upp och Ned
        "<".Position(UN, HV, color);
        Thread.Sleep(100);
        " ".Position(UN, HV, color);
        UN--; HV++;
        "<".Position(UN, HV, color);
        Thread.Sleep(100);
        " ".Position(UN, HV, color);
        UN--; HV++;
        "<".Position(UN, HV, color);
        Thread.Sleep(100);
        " ".Position(UN, HV, color);
        UN--; HV++;
        "<".Position(UN, HV, color);
        Thread.Sleep(100);
        " ".Position(UN, HV, color);
        UN--; HV++;
        "<".Position(UN, HV, color);
        Thread.Sleep(100);
        " ".Position(UN, HV, color);
        
    }
    public static void HeroAttack()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        int UN = 58; // Höger och vänster
        int HV = 5; // Upp och Ned
        ">".Position(UN, HV);
        Thread.Sleep(100);
        " ".Position(UN, HV);
        UN++; HV++;
        ">".Position(UN, HV);
        Thread.Sleep(100);
        " ".Position(UN, HV);
        UN++; HV++;
        ">".Position(UN, HV);
        Thread.Sleep(100);
        " ".Position(UN, HV);
        UN++; HV++;
        ">".Position(UN, HV);
        Thread.Sleep(100);
        " ".Position(UN, HV);
        UN++; HV++;
        ">".Position(UN, HV);
        Thread.Sleep(100);
        " ".Position(UN, HV);

    }
    public static void PlaceCursorDefault()
    {
        FillInfoSquare();
        " ".Position(95, 27, "Cyan");
    }
    public static string PressC()
    {
        Thread.Sleep(1000);
        return "Tryck på 'C' för att fortsätta";
    }
    public static void DoPressC()
    {
        //char button = Convert.ToChar(Console.ReadKey().KeyChar);
        char button = 'f';
        while (button != 'c' && button != 'C')
        {
            button = Convert.ToChar(Console.ReadKey().KeyChar);
        }
        Graphics.FillInfoSquare();
    }
    public static void FillInfoSquare()
    {
        for (int i = 26; i < 40; i++)
        {
            shortLine.Position(93, i, "Cyan");
        }
        Console.SetCursorPosition(95, 27);
    }

    public static void printAre1a()
    {
        int x = 24;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta");        x++;
        "                    ".Position(69, x, "Magenta"); x++;
        "                    ".Position(69, x, "Magenta"); x++;


        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre2a()
    {
        int x = 1;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "    ".Position(85, x, "Magenta"); x++;
        "                    ".Position(69, x, "Magenta"); x++;
        "                    ".Position(69, x, "Magenta"); x++;
        "                    ".Position(69, x, "Magenta"); x++;
        "                    ".Position(69, x, "Magenta"); x++;
        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre3a()
    {
        int x = 19;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "       ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;
        "                   ".Position(31, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre4a()
    {
        int x = 31;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;
        "                       ".Position(46, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre5a()
    {
        int x = 20;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;
        "                   ".Position(50, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre6a()
    {
        int x = 27;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre7a()
    {
        int x = 17;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;
        "                              ".Position(1, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre8a()
    {
        int x = 6;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "     ".Position(6, x, "Magenta"); 
        "     ".Position(14, x, "Magenta"); x++;
        "     ".Position(6, x, "Magenta");
        "     ".Position(14, x, "Magenta"); x++;
        "     ".Position(6, x, "Magenta");
        "     ".Position(14, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta");
        " ".Position(16, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta");
        " ".Position(16, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta");
        " ".Position(16, x, "Magenta"); x++; 
        " ".Position(8, x, "Magenta");
        " ".Position(16, x, "Magenta"); x++;
        "         ".Position(8, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta"); x++;
        " ".Position(8, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre9a()
    {
        int x = 1;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "         ".Position(50, x, "Magenta");
        "                                      ".Position(1, x, "Magenta"); x++;
        "         ".Position(50, x, "Magenta");
        "                                      ".Position(1, x, "Magenta"); x++;
        "         ".Position(50, x, "Magenta");
        "                                      ".Position(1, x, "Magenta"); x++;
        "         ".Position(50, x, "Magenta");
        "                                      ".Position(1, x, "Magenta"); x++;
        "         ".Position(50, x, "Magenta");
        "                                      ".Position(1, x, "Magenta"); x++;
        "     ".Position(1, x, "Magenta");
        "   ".Position(11, x, "Magenta");
        "                                        ".Position(19, x, "Magenta"); x++;
        "     ".Position(1, x, "Magenta");
        "   ".Position(11, x, "Magenta");
        "                                        ".Position(19, x, "Magenta"); x++;
        "     ".Position(1, x, "Magenta");
        "   ".Position(11, x, "Magenta");
        "                                        ".Position(19, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "       ".Position(9, x, "Magenta");
        "                                          ".Position(17, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "       ".Position(9, x, "Magenta");
        "                                          ".Position(17, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "       ".Position(9, x, "Magenta");
        "                                          ".Position(17, x, "Magenta"); x++; 
        "       ".Position(1, x, "Magenta");
        "       ".Position(9, x, "Magenta");
        "                     ".Position(17, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "                     ".Position(17, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "                             ".Position(9, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "                             ".Position(9, x, "Magenta"); x++;
        "       ".Position(1, x, "Magenta");
        "                             ".Position(9, x, "Magenta"); x++;
        "       ".Position(31, x, "Magenta"); x++;
        "       ".Position(31, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre10a()
    {
        int x = 1;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "             ".Position(39, x, "Blue"); x++;
        "             ".Position(39, x, "Blue"); x++;
        "             ".Position(39, x, "Blue"); x++;
        "             ".Position(39, x, "Blue"); x++;
        "             ".Position(39, x, "Blue"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre11a()
    {
        int x = 12;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;
        "                       ".Position(38, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void printAre12a()
    {
        int x = 1;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                          ".Position(59, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;
        "                        ".Position(61, x, "Magenta"); x++;

        Console.BackgroundColor = ConsoleColor.Black;
    }
    
    
    //public static void printAre13a()
    //{
    //    int x = 1;
    //    Console.BackgroundColor = ConsoleColor.DarkRed;
    //    "   ".Position(86, x, "Magenta"); x++;

    //    Console.BackgroundColor = ConsoleColor.Black;
    //}
    //public static void printAre14a()
    //{
    //    int x = 1;
    //    Console.BackgroundColor = ConsoleColor.DarkRed;
    //    "   ".Position(86, x, "Magenta"); x++;

    //    Console.BackgroundColor = ConsoleColor.Black;
    //}
    //public static void printAre15a()
    //{
    //    int x = 1;
    //    Console.BackgroundColor = ConsoleColor.DarkRed;
    //    "   ".Position(86, x, "Magenta"); x++;

    //    Console.BackgroundColor = ConsoleColor.Black;
    //}
}
