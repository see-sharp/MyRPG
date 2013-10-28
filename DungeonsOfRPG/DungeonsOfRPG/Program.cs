using System;
using System.Collections.Generic;
using System.Threading;


class Program
{
    public static Player HeroTest = new Player("Martin", "M", 5, 20, 10, "eld");
    public static Player Hero;
    public static Map MyMap;
    public static string X = Convert.ToString((char)2);
    public static string Y = Convert.ToString((char)1);
    public static List<GroupOfEnemies> EnemyGroups = new List<GroupOfEnemies>(); // glöm inte att adda i createListWithGroupOfEnemies
    #region

    public static GroupOfEnemies FinalBoss = new GroupOfEnemies(Y, 1, 45, 10, new List<Enemies>{
            new Enemies("Slut-Boss", Y, 0, 200, 0, "inget"),
            });
    public static GroupOfEnemies PrisonGuard = new GroupOfEnemies(X, 34, 32, 0, new List<Enemies>{ // 34,32 är startvärde för första battle
            new Enemies("Prisoner-Guard", "W", 0, 4, 0, "inget"), // sätt till 040
            });
    public static GroupOfEnemies A = new GroupOfEnemies(X, 35, 82, 1, new List<Enemies>{
            new Enemies("Warrior1", "W", 0, 15, 0, "inget"),
            new Enemies("Warrior2", "W", 0, 15, 0, "inget"),
            new Enemies("Warrior3", "W", 0, 15, 0, "inget"),
            new Enemies("Warrior4", "W", 0, 15, 0, "inget"),
            new Enemies("Warrior5", "W", 0, 15, 0, "inget")
            });
    public static GroupOfEnemies AA = new GroupOfEnemies(X, 30, 80, 1, new List<Enemies>{
            new Enemies("Ifrit", "F", 0, 40, 0, "eld"),
            new Enemies("Zub-Zero", "F", 0, 40, 0, "is")
            });
    public static GroupOfEnemies B = new GroupOfEnemies(X, 3, 88, 2, new List<Enemies>{
            new Enemies("Grog", "F", 0, 40, 0, "inget"),
            new Enemies("Dolan", "F", 0, 40, 0, "inget")
            }); 
    public static GroupOfEnemies C = new GroupOfEnemies(X, 23, 37, 3, new List<Enemies>{
            new Enemies("Fire-Mage", "F", 0, 20, 0, "eld"),
            new Enemies("Fire-Wizard", "F", 0, 30, 0, "eld"),
            });
    public static GroupOfEnemies CC = new GroupOfEnemies(X, 28, 44, 3, new List<Enemies>{
            new Enemies("Frost", "F", 0, 18, 0, "is"),
            new Enemies("FahrenHeit", "F", 0, 22, 0, "is"),
            });
    public static GroupOfEnemies CCC = new GroupOfEnemies(X, 27, 38, 3, new List<Enemies>{
            new Enemies("Ice-Man", "F", 0, 23, 0, "is"),
            new Enemies("Clint", "F", 0, 40, 0, "inget"),
            new Enemies("Frap", "F", 0, 10, 0, "inget"),
            });
    public static GroupOfEnemies D = new GroupOfEnemies(X, 33, 55, 4, new List<Enemies>{
            new Enemies("Wrong", "W", 0, 25, 0, "inget"),
            new Enemies("Wrangler", "F", 0, 10, 0, "eld"),
            new Enemies("Pilz", "I", 0, 30, 0, "is")
            });
    public static GroupOfEnemies DD = new GroupOfEnemies(X, 38, 49, 4, new List<Enemies>{
            new Enemies("Poku", "W", 0, 50, 0, "inget"),
            });
    public static GroupOfEnemies E = new GroupOfEnemies(X, 24, 60, 5, new List<Enemies>{
            new Enemies("Rikz", "I", 0, 10, 0, "is"),
            new Enemies("Fire-Mike", "F", 0, 27, 0, "eld"),
            new Enemies("Woff", "I", 0, 37, 0, "is")
            });
    public static GroupOfEnemies F = new GroupOfEnemies(X, 34, 13, 6, new List<Enemies>{
            new Enemies("Fighter1", "W", 0, 15, 0, "inget"),
            new Enemies("Fighter2", "W", 0, 15, 0, "inget"),
            new Enemies("Fighter3", "W", 0, 15, 0, "inget"),
            new Enemies("Fighter4", "W", 0, 15, 0, "inget"),
            new Enemies("Fighter5", "W", 0, 15, 0, "inget")
            });
    public static GroupOfEnemies FF = new GroupOfEnemies(X, 32, 2, 6, new List<Enemies>{
            new Enemies("Zlash", "W", 0, 58, 0, "eld")
            });
    public static GroupOfEnemies G = new GroupOfEnemies(X, 21, 23, 7, new List<Enemies>{
            new Enemies("Aten", "I", 0, 10, 0, "is"),
            new Enemies("Sparta", "I", 0, 10, 0, "is"),
            new Enemies("Thebe", "I", 0, 10, 0, "is"),
            new Enemies("Korint", "I", 0, 10, 0, "is"),
            });
    public static GroupOfEnemies GG = new GroupOfEnemies(X, 24, 15, 7, new List<Enemies>{
            new Enemies("Sander", "W", 0, 29, 0, "eld"),
            new Enemies("Bolt", "W", 0, 19, 0, "inget")
            });
    public static GroupOfEnemies H = new GroupOfEnemies(X, 7, 8, 8, new List<Enemies>{
            new Enemies("Shiva", "F", 0, 31, 0, "is"),
            new Enemies("Boff", "F", 0, 42, 0, "inget")
            });
    public static GroupOfEnemies I = new GroupOfEnemies(X, 14, 32, 9, new List<Enemies>{
            new Enemies("Biff", "I", 0, 20, 0, "inget"),
            new Enemies("Blast", "F", 0, 27, 0, "is"),
            new Enemies("Mars", "I", 0, 22, 0, "inget")
            });
    public static GroupOfEnemies II = new GroupOfEnemies(X, 2, 12, 9, new List<Enemies>{
            new Enemies("Boff", "I", 0, 70, 0, "inget"),
            new Enemies("Huxley", "I", 0, 21, 0, "eld")
            });
    public static GroupOfEnemies III = new GroupOfEnemies(X, 10, 38, 9, new List<Enemies>{
            new Enemies("Lazer", "I", 0, 10, 0, "eld"),
            new Enemies("Blaze", "I", 0, 10, 0, "eld"),
            new Enemies("Blazer", "I", 0, 10, 0, "eld"),
            new Enemies("Leraz", "I", 0, 10, 0, "eld"),
            });
    public static GroupOfEnemies J = new GroupOfEnemies(X, 12, 51, 11, new List<Enemies>{
            new Enemies("Phoenix", "I", 0, 45, 0, "eld"),
            new Enemies("Golf", "F", 0, 22, 0, "inget")
            });
    public static GroupOfEnemies JJ = new GroupOfEnemies(X, 18, 52, 11, new List<Enemies>{
            new Enemies("Zombie", "I", 0, 70, 0, "inget"),
            new Enemies("Flan", "I", 0, 24, 0, "is")
            });
    public static GroupOfEnemies K = new GroupOfEnemies(X, 17, 72, 12, new List<Enemies>{
            new Enemies("Fang", "I", 0, 45, 0, "inget"),
            new Enemies("Bao", "F", 0, 50, 0, "inget"),
            new Enemies("Razoralf", "F", 0, 10, 0, "inget")
            });
    public static GroupOfEnemies KK = new GroupOfEnemies(X, 3, 77, 12, new List<Enemies>{
            new Enemies("Klaps", "F", 0, 10, 0, "eld"),    
            new Enemies("Plafs", "I", 0, 20, 0, "inget"),
            new Enemies("Opal", "F", 0, 50, 0, "is")
            });
    
    
    #endregion


    // Methods
    public static void createListWithGroupOfEnemies()
    {
        EnemyGroups.Add(FinalBoss);
        EnemyGroups.Add(PrisonGuard);
        EnemyGroups.Add(A);
        EnemyGroups.Add(AA);
        EnemyGroups.Add(B);
        EnemyGroups.Add(C);
        EnemyGroups.Add(CC);
        EnemyGroups.Add(CCC);
        EnemyGroups.Add(D);
        EnemyGroups.Add(DD);
        EnemyGroups.Add(E);
        EnemyGroups.Add(F);
        EnemyGroups.Add(FF);
        EnemyGroups.Add(G);
        EnemyGroups.Add(GG);
        EnemyGroups.Add(H);
        EnemyGroups.Add(I);
        EnemyGroups.Add(II);
        EnemyGroups.Add(III);
        EnemyGroups.Add(J);
        EnemyGroups.Add(JJ);
        EnemyGroups.Add(K);
        EnemyGroups.Add(KK);

    }
    public static void createItems()
    {
        string P = Convert.ToString((char)19);
        //Item X = new Item("Postionsletare", "2", 15, 50);
        //Item Xa = new Item("Postionsletare", "1", 10, 75);
        Item Potion1 = new Item("Helande dryck", P, 31, 54);
        Item Potion2 = new Item("Helande dryck", P, 6, 18);
        Item Potion3 = new Item("Helande dryck", P, 38, 88);
        Item Potion4 = new Item("Helande dryck", P, 21, 25);
        Item Potion5 = new Item("Helande dryck", P, 27, 3);
        Item Potion6 = new Item("Helande dryck", P, 22, 6);
        Item Potion7 = new Item("Helande dryck", P, 22, 88);
        Item Potion8 = new Item("Helande dryck", P, 19, 38);
        Item Potion9 = new Item("Helande dryck", P, 1, 37);
        Item Potion10 = new Item("Helande dryck", P, 18, 83);
        Item Potion11 = new Item("Helande dryck", P, 12, 55);
        Item Potion12 = new Item("Helande dryck", P, 8, 10);
        Item Mana1 = new Item("Magisk dryck", P, 10, 14);
        Item Mana2 = new Item("Magisk dryck", P, 3, 69);
        Item Mana3 = new Item("Magisk dryck", P, 23, 19);
        Item Mana4 = new Item("Magisk dryck", P, 25, 69);

        Item GoldKey = new Item("Nyckel av guld", P, 34, 12);
        Item SilverKey = new Item("Nyckel av silver", P, 30, 82);
        Item Bronze = new Item("Nyckel av brons", P, 12, 40);
        Item KeyChest = new Item("Nyckel av platina", P, 1, 86);

        Item StartUpValues = new Item("Spelarens föremål:", P, 38, 44);

    }
    public static void consoleProperty()
    {
        Console.Title = "The Escape";
        Console.SetWindowSize(143, 45); // todounder utveckling är det 45, annars 40
    }

    
    public static void CharactersActs()
    {
        Hero.Action();
        
        foreach (var g in EnemyGroups)
        {
            g.Move(g);
        }
    }
   
    public static void GamePlay()
    {
        while (true)
        {
            CharactersActs();
            MyMap.UpdateMap();

            //kolla om det blir battle
            foreach (var g in EnemyGroups)
            {
                //Battle.CheckIfBattle(Program.Hero.MapPositioni, Program.Hero.MapPositionj, MapPositioni, MapPositionj); //g.Move(g);
                if (g.GroupAlive == true)
                {
                    Battle.CheckIfBattle(Hero, g);
                }
            }
            MyMap.UpdateMap();
            
        }
    }
    private static void story()
    {
        int x = 10;
        Console.Clear();
        "Du har blivit tillfångatagen och placerad i en fängelsehåla. Du ligger och tänker på de färdigheter du har.".Position(10, x, "Cyan");
        x++;
        ("En av dem är din förmåga att anfalla med " + Hero.Element + "-magi. Dina magipoäng (MP) är slut så även om du ").Position(10, x, "Cyan");
        x++;
        "skulle anfalla med magi gör du ingen skada förrän du har MP igen. ".Position(10, x, "Cyan");
        x++;
        "Ditt vapen är borta och du gör knappt någon skada om du skulle slå mot en fiende.".Position(10, x, "Cyan");
        x++;
        Graphics.PressC().Position(10, x, "DarkCyan");
        Graphics.DoPressC();
        x++;
        "Du kommer ihåg att dörren ut till friheten är precis till höger när du kommer ut från din cell, och alla".Position(10, x, "Cyan");
        x++; 
        "dina föremål ligger i en cell precis mitt emot din. ".Position(10, x, "Cyan");
        x++;
        Graphics.PressC().Position(10, x, "DarkCyan");
        Graphics.DoPressC();
        x++;
        "Du hör en fångvaktare vrida om nyckeln till din cell och nu bestämmer du dig för att rymma!".Position(10, x, "Cyan");
        x++;
        x++;
        "Tryck på 'C' för att anfalla din fiende och börja ditt äventyr mot friheten!".Position(10, x, "Yellow");
        Graphics.DoPressC();
    }
    private static void createPlayer()
    {
        int x = 5; 
        "Vad ska din spelare heta?".Position(20, x, "Cyan");
        x++;
        "-> ".Position(20, x, "Cyan");
        x++;
        x++;
        x++;
        string name = Console.ReadLine();

        string chooseElement = "";
        string element = "";
        string ok = "";
        int x2 = x;
        while (ok != "ok")
        {
            x2 = x;
            Graphics.fillMenuInBattle.Position(23, 15, "Red");
            
            "Det finns två sorter av magi, eld och is. Eld-magi gör stor skada på fiender med is-element och ingen".Position(20, x2, "Cyan");
            x2++;
            "skada på dem med eld-element. Vice versa för is-magi. Om du väljer eld som ditt element så är det en".Position(20, x2, "Cyan");
            x2++;
            "bra ide att slå ut is-fiender först eftersom de gör stor skada på dig, medan eld-fiender knappt gör någon".Position(20, x2, "Cyan");
            x2++;
            "skada.".Position(20, x2, "Cyan");
            x2++;
            x2++;
            "Vilket element ska vara ditt bästa? Tryck 'e' för eld och 'i' för is".Position(20, x2, "Cyan");
            x2++;
            "-> ".Position(20, x2, "Cyan");
            chooseElement = Console.ReadLine().ToLower();


            if (chooseElement == "e")
                element = "eld";
            else if (chooseElement == "i")
                element = "is";
            if (element == "eld" || element == "is")
                ok = "ok";
        }
        x2++;
        x2++;
        "Fiender vars namn visas i blått har is som sitt element.".Position(20, x2, "Blue");
        x2++;
        "Fiender vars namn visas i rött har eld som sitt element.".Position(20, x2, "Red");
        x2++;
        "Fiender vars namn visas i gult har inget speciellt element.".Position(20, x2, "Yellow");
        x2++;
        x2++;
        Graphics.PressC().Position(20, x2, "DarkCyan");
        Graphics.DoPressC();
        x2++;
        x2++;
        "TECKENFÖRKLARINGAR: ".Position(20, x2, "Cyan");
        x2++;
        ("Föremål som " + name + " kan plocka upp: ").Position(20, x2, "Cyan");
        string Q = Convert.ToString((char)19);
        x2++;
        Q.Position(20, x2, "Yellow");
        x2++;
        ("Symbolen för " + name + ": ").Position(20, x2, "Cyan"); 
        x2++;
        X.Position(20, x2, "Green");
        x2++;
        ("Symbolen för fiender: ").Position(20, x2, "Cyan"); 
        x2++;
        X.Position(20, x2, "Red");
        x2++;
        x2++;

        Graphics.PressC().Position(20, x2, "DarkCyan");
        Graphics.DoPressC();
        Hero = new Player(name, X, 1, 35, 0, element); // ska bli den skarpa spelaren vid spel-release

    }
    static void Main()
    {
        consoleProperty();
       
        
        MyMap = new Map();
        createListWithGroupOfEnemies();
        createItems();

        //Hero = new Player("Martin", X, 5, 100, 15, "eld"); // test under uppbyggnad av program
        
        createPlayer(); // Om man kommenterar ut createPlayer och story måste man Okommentera Hero 2 rader upp
        story();
        
        Battle.FirstBattle();
        
        Graphics.FillInfoSquare();
        GamePlay();

    }
}

