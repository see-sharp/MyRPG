using System;
using System.Collections.Generic;

public class Item
{
    // Properties
    public string Name { get; set; }
    public string Marker { get; set; }
    public int MapPositioni { get; set; }
    public int MapPositionj { get; set; }
    public static List<Item> ItemList = new List<Item>();
    public bool OnMap = true;

    // Constructor
    public Item(string name, string marker, int mapPositioni, int mapPositionj)
    {
        Name = name;
        Marker = marker;
        MapPositioni = mapPositioni;
        MapPositionj = mapPositionj;
        Program.MyMap.GetItemPositions(mapPositioni, mapPositionj, marker);
        addItemToList(this);
        OnMap = true;
    }
    
    public static void StartUpKit()
    {
        Program.Hero.HP = Program.Hero.MaxHP; // Ändra till MaxHP
        Program.Hero.MP = Program.Hero.MaxMP;
        Program.Hero.Strength = 10;
        Program.Hero.NumberOfMagicPotions = 1;
        Program.Hero.NumberOfHealingPotions = 3;
        Program.Hero.PlayerItems.Add("Helande dryck");
        Program.Hero.PlayerItems.Add("Helande dryck");
        Program.Hero.PlayerItems.Add("Helande dryck");
        Program.Hero.PlayerItems.Add("Magisk dryck");
        
        // Ett fusk som gör spelaren jättestark
        if (Program.Hero.Name == "Alex Kidd")
        {
            Program.Hero.Strength = 250;
            Program.Hero.HP = 2000;
        }
        InfoAboutStartupKit();
    }
    public static void InfoAboutStartupKit()
    {
        "Du hittar alla dina föremål på en hylla!".Position(95, 27, "Cyan");
        "Du dricker en helande dryck som återställer".Position(95, 28, "Cyan");
        "dina HP och du lägger ner tre helande drycker".Position(95, 29, "Cyan");
        "i din väska. Du dricker också en magi-dryck".Position(95, 30, "Cyan");
        ("och kan nu göra skada med din " + Program.Hero.Element + "-magi igen.").Position(95, 31, "Cyan");
        "En magisk dryck lägger du i din väska.".Position(95, 32, "Cyan");
        "Du ser ditt svärd stå lutat mot väggen,".Position(95, 33, "Cyan");
        "du spänner på dig det och känner din styrka".Position(95, 34, "Cyan");
        "komma tillbaka i kroppen!".Position(95, 35, "Cyan");
        Graphics.PressC().Position(95, 37, "DarkCyan");
        Graphics.DoPressC();
    }
    // Methods
    public static void addItemToList(Item i)
    {
        ItemList.Add(i);
    }
}

