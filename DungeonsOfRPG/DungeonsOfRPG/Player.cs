using System;
using System.Collections.Generic;

public class Player : Characters
{
    // Fields
    private bool moveOk = false;
    private int maxHP;
    private int maxMP;
    
    // Properties : Characters
    public override string Marker
    {
        get
        {
            return marker;
        }
        set
        {
            marker = value;
        }
    }
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override int Strength { get; set; }
    public override int HP { get; set; }
    public override int MP { get; set; }
    public override string Element { get; set; }
    public override int MapPositioni
    {
        get
        {
            return mapPositioni;
        }
        set
        {
            mapPositioni = value;
        }
    }
    public override int MapPositionj
    {
        get
        {
            return mapPositionj;
        }
        set
        {
            mapPositionj = value;
        }
    }
    public override int PrevMapPositioni { get; set; }
    public override int PrevMapPositionj { get; set; }
   
    

    // Properties NOT inherit
    public int MaxHP
    {
        get
        {
            return maxHP;
        }
        set
        {
            maxHP = value;
        }
    }
    public int MaxMP {
        get
        {
            return maxMP;
        }
        set
        {
            maxMP = value;
        }
    }
    public int NumberOfMagicPotions { get; set; }
    public int NumberOfHealingPotions { get; set; }
    public List<string> PlayerItems = new List<string>();
    
    // Constructor
    public Player(string _name, string _marker, int _strength, int _hp, int _mp, string _element )
    {
        Strength = _strength;
        HP = _hp;
        Name = _name;
        Marker = Convert.ToString((char)2);;
        MP = _mp;
        Element = _element;

        MaxHP = 90;
        MaxMP = 5;
        MapPositioni = 35; // 35 eller 39 // 3
        MapPositionj = 32; // 32 eller 38 // 41
        PrevMapPositioni = 38;
        PrevMapPositionj = 38;
        NumberOfMagicPotions = 0; 
        NumberOfHealingPotions = 0; // todo NumberOHP används för att hålla reda på räkningen, PlayerItems för det grafiska
        


    }
    // Methods
    private void checkIfMoveIsOk(int i, int j)
    {
        if (Map.mapLayout[i, j] == " ")
            moveOk = true;
    }
    public override void Action()
    {
        Graphics.PlaceCursorDefault();

        moveOk = false;
        PrevMapPositioni = MapPositioni;
        PrevMapPositionj = MapPositionj;

        while (moveOk == false)
        {
            char arrow = Convert.ToChar(Console.ReadKey().KeyChar);
            
            if (arrow == 'a' || arrow == 'A')
            {
                checkIfMoveIsOk(MapPositioni, (MapPositionj -1));
                if (moveOk == true)
                    Program.Hero.MapPositionj--;
            }
            else if (arrow == 'd' || arrow == 'A')
            {
                checkIfMoveIsOk(MapPositioni, MapPositionj + 1);
                if (moveOk == true)
                    Program.Hero.MapPositionj++;
            }
            else if (arrow == 'w' || arrow == 'W')
            {
                checkIfMoveIsOk(MapPositioni - 1, MapPositionj);
                if (moveOk == true)
                    Program.Hero.MapPositioni--;
            }
            else if (arrow == 's' || arrow == 'S')
            {
                checkIfMoveIsOk(MapPositioni + 1, MapPositionj);
                if (moveOk == true)
                    Program.Hero.MapPositioni++;
            }
            else if (arrow == 'i' || arrow == 'I')
            {
                closeToItem();
            }
            else if (arrow == 'h' || arrow == 'H')
            {
                playerDrinksHPMap();
            }
            else if (arrow == 'm' || arrow == 'M')
            {
                playerDrinksMPMap();
            }
            
        }
    }
    public void closeToItem()
    {
        foreach (Item item in Item.ItemList)
        {
            if (item.OnMap == true)
            {
                // Kolla om spelaren står i en närliggande ruta till ett Item
                if (
                    // nedåt
                    (MapPositioni == (item.MapPositioni + 1) && MapPositionj == item.MapPositionj)
                    // uppåt
                || (MapPositioni == (item.MapPositioni - 1) && MapPositionj == item.MapPositionj)
                    // höger
                || (MapPositioni == item.MapPositioni && MapPositionj == (item.MapPositionj + 1))
                    // vänster
                || (MapPositioni == item.MapPositioni && MapPositionj == (item.MapPositionj - 1))
                    )
                {

                    takeItem(item);
                    
                    //Program.MyMap.printItems(); har flyttat denna till Map.printmap
                }
            }
        }// slut på foreach
    }// slut på metod
    private void changeItemStatus(Item i)
    {
        Program.Hero.PlayerItems.Add(i.Name);
        if (i.Name == "Helande dryck")
            Program.Hero.NumberOfHealingPotions++;
        else if (i.Name == "Magisk dryck")
            Program.Hero.NumberOfMagicPotions++;

        i.Marker = " ";
        i.OnMap = false;
    }
    public void takeItem(Item i)
    {
        if (i.Name == "Spelarens föremål:")
        {
            changeItemStatus(i);
            Item.StartUpKit();
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
        }
        if (i.Name == "Helande dryck")
        {
            changeItemStatus(i);
            "Du hittar en helande dryck!".Position(95, 27, "Cyan");
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
        }
        if (i.Name == "Magisk dryck")
        {
            changeItemStatus(i);
            "Du hittar en magisk dryck!".Position(95, 27, "Cyan");
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
        }
        if (i.Name == "Nyckel av guld")
        {
            changeItemStatus(i);
            "Du hittar en nyckel av guld!".Position(95, 27, "Cyan");
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
        } 
        if (i.Name == "Nyckel av silver")
        {
            changeItemStatus(i);
            "Du hittar en nyckel av silver!".Position(95, 27, "Cyan");
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
        } 
        if (i.Name == "Nyckel av brons")
        {
            changeItemStatus(i);
            "Du hittar en nyckel av brons!".Position(95, 27, "Cyan");
            " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
        } 
        if (i.Name == "Nyckel av platina")
        {
            if ((i.Name == "Nyckel av platina") && (Program.Hero.PlayerItems.Contains("Nyckel av guld") && Program.Hero.PlayerItems.Contains("Nyckel av silver") && Program.Hero.PlayerItems.Contains("Nyckel av brons")))
            {
                changeItemStatus(i);
                PlayerItems.Remove("Nyckel av guld");
                PlayerItems.Remove("Nyckel av silver");
                PlayerItems.Remove("Nyckel av brons");
                
                Graphics.FillInfoSquare();
                "Du öppnar en kista med dina tre nycklar".Position(95, 27, "Cyan");
                "och hittar en nyckel av platina!".Position(95, 28, "Cyan");
                "Guld, silver- och bronsnycklarna sitter".Position(95, 29, "Cyan");
                "kvar i kistan".Position(95, 30, "Cyan");
                " ".Position(i.MapPositionj, i.MapPositioni); Console.SetCursorPosition(95, 27);
                Graphics.PressC().Position(95, 32, "DarkCyan");
                Graphics.DoPressC();
            }
            else
            {
                Graphics.FillInfoSquare();
                "Du hittar en kista men behöver tre ".Position(95, 27, "Cyan");
                "olika nycklar för att öppna den".Position(95, 28, "Cyan");
                Graphics.PressC().Position(95, 30, "DarkCyan");
                Graphics.DoPressC();
            }
        }
    }

    public void playerDrinksHP()
    {
        if (Program.Hero.NumberOfHealingPotions > 0)
        {
            Program.Hero.HP = MaxHP;
            Program.Hero.NumberOfHealingPotions--;
            Program.Hero.PlayerItems.Remove("Helande dryck");
            ("Du dricker en helande dryck och återställer dina HP!").Position(30, 20, "Cyan");
        }
        else
        {
            "Du har ingen helande dryck!".Position(30, 20, "Cyan");
        }
    }
    public void playerDrinksMP()
    {
        if (Program.Hero.NumberOfMagicPotions > 0)
        {
            Program.Hero.MP = MaxMP;
            Program.Hero.NumberOfMagicPotions--;
            Program.Hero.PlayerItems.Remove("Magisk dryck");
            ("Du dricker en magisk dryck och återställer dina MP!").Position(30, 20, "Cyan");
        }
        else
        {
            "Du har ingen magisk dryck!".Position(30, 20, "Cyan");
        }
    }
    public void playerDrinksHPMap()
    {
        if (Program.Hero.NumberOfHealingPotions > 0)
        {
            Graphics.FillInfoSquare();
            Program.Hero.HP = MaxHP;
            Program.Hero.NumberOfHealingPotions--;
            Program.Hero.PlayerItems.Remove("Helande dryck");
            ("Du dricker en helande dryck och").Position(95, 27, "Cyan");
            ("återställer dina HP!").Position(95, 28, "Cyan");
        }
        else
        {
            "Du har ingen helande dryck!".Position(95, 27, "Cyan");
        }
    }
    public void playerDrinksMPMap()
    {
        if (Program.Hero.NumberOfMagicPotions > 0)
        {
            Graphics.FillInfoSquare();
            Program.Hero.MP = MaxMP;
            Program.Hero.NumberOfMagicPotions--;
            Program.Hero.PlayerItems.Remove("Magisk dryck");
            ("Du dricker en magisk dryck och").Position(95, 27, "Cyan");
            ("återställer dina MP!").Position(95, 28, "Cyan");
        }
        else
        {
            "Du har ingen magisk dryck!".Position(95, 27, "Cyan");
        }
    }
    public int PlayerWeaponAttack(int strength) // todo, ska lägga till vapen
    {
        Random rand = new Random();
        int damage = strength + rand.Next(5, 16);

        //nedanstående if är bara för för första fighten
        if (strength == 1)
            damage = 1;

        return damage;
    }
    public int PlayerMagicAttack(string element, Enemies enemy)
    {
        int damage = 0;
        if (Program.Hero.MP > 0)
        {
            Random rand = new Random();
            damage = rand.Next(5, 16);

            if (enemy.Element == "inget")
                damage -= 0;
            else if (enemy.Element == Program.Hero.Element)
                damage = 0;
            else if (enemy.Element != Program.Hero.Element)
                damage += 20;
            MP--;
        }

        return damage;
    }
    
}

