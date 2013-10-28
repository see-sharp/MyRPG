using System;
using System.Collections.Generic;

class Battle
{
    // Properties
    private static List<Characters> TurnQueList = new List<Characters>();
    private static bool battleOver = false;
    // Constructor



    // Methods
    
    // To inizialise battle
    public static void CheckIfBattle(Player player, GroupOfEnemies enemy)
    {
        // Kolla om spelaren står i en närliggande ruta om GroupOfEnemies
        if (
            // nedåt
            (player.MapPositioni == (enemy.MapPositioni + 1) && player.MapPositionj == enemy.MapPositionj)
            // uppåt
        || (player.MapPositioni == (enemy.MapPositioni - 1) && player.MapPositionj == enemy.MapPositionj)
            // höger
        || (player.MapPositioni == enemy.MapPositioni && player.MapPositionj == (enemy.MapPositionj + 1))
            // vänster
        || (player.MapPositioni == enemy.MapPositioni && player.MapPositionj == (enemy.MapPositionj - 1))
            )
        {
            "Du blir attackerad!".Position(95, 27, "Red");
            Graphics.PressC().Position(95, 29, "DarkRed");
            Graphics.DoPressC();
            startBattle(enemy);
        }
    }
    private static void createTurnQueList(GroupOfEnemies enemy)
    {
        // måste clear() innan varje gång, annars innehåller listan namn från förra battle.
        TurnQueList.Clear();
        foreach (Enemies e in enemy.EnemyList)
        {
            TurnQueList.Add(e);
        }
        TurnQueList.Insert(1, Program.Hero);
        
    }
    private static void startBattle(GroupOfEnemies enemy)
    {
        createTurnQueList(enemy);
        
        battleRuns(enemy);

    }
    public static void GameOver()
    {
        "Du är död och spelet är slut!    ".Position(20, 25, "Red");
        battleOver = true;
        Environment.Exit(0);

    }
    private static void bossDefeated()
    {
        "Du kommer levande ut ur striden och har dödat Slut-Bossen!".Position(20, 25, "Green");
        "Du ser att en nyckel av adamant hänger om Slut-Bossens hals, den stoppar du på dig".Position(20, 27, "Cyan");
        Program.Hero.PlayerItems.Add("Nyckel av adamant");
        Graphics.PressC().Position(20, 29, "DarkCyan");
        Graphics.DoPressC();
    }
    public static void BattleWon()
    {
        "Du kommer levande ut ur striden!".Position(25, 25, "Green");
        Console.ReadKey();
        battleOver = true;
        if (Program.FinalBoss.GroupAlive == false)
            bossDefeated();
        Program.MyMap.AfterBattle();
    }
    // Print on Screen, called upon from updatePrintInfo
    private static void printPlayer()
    {
        (Program.Hero.Name + "  HP: " + Program.Hero.HP + " / " + Program.Hero.MaxHP).Position(30, 5, "Green");
        ("Element: " + Program.Hero.Element).Position(30, 6, "Green");
        ("MP kvar: " + Program.Hero.MP + " / " + Program.Hero.MaxMP).Position(30, 7, "Green");
        ("Styrka: " + Program.Hero.Strength).Position(30, 8, "Green");
    }
    private static void printEnemies(GroupOfEnemies enemy)
    {
        int number = 1;
        int y = 5;
        string color = " ";
        foreach (Enemies e in enemy.EnemyList)
        {
            if (e.Element == "inget")
                color = "Yellow";
            else if (e.Element == "eld")
                color = "Red";
            else if (e.Element == "is")
                color = "Blue";
            
            if (e.HP != 0)
                (number + ". " + e.Name + " HP: " + e.HP).Position(80, y, color);
            else
                (number + ". " + e.Name + " HP: " + e.HP + " - Fienden ÄR DÖD!!").Position(80, y, color);
            y += 5;
            number++;
        }
    }
    private static void printTurnQueList()
    {
        int y = 4;
        "Turordning: ".Position(4, 2, "Cyan");
        foreach (Characters c in TurnQueList)
        {
            (c.Name).Position(4, y, "Cyan");
            y++;
        }
    }
    

    // When battle runs
    private static void updatePrintInfo(GroupOfEnemies enemy)
    {
        Console.Clear();
        printPlayer();
        printEnemies(enemy);
        printTurnQueList();
    }
    private static void isEnemyDead(GroupOfEnemies enemy)
    {
        foreach (Enemies e in enemy.EnemyList)
        {
            if (e.HP <= 0)
            {
                e.Alive = false;
                TurnQueList.Remove(e);
            }
        }
    }
    private static void isBattleOver(GroupOfEnemies enemy)
    {
        // Kolla om spelaren lever
        if (Program.Hero.HP <= 0){ GameOver();}
        
        // Kolla om någon i fiende-gruppen är död. 
        enemy.GroupAlive = false;
        foreach (Enemies e in enemy.EnemyList)
        {
            if (e.HP > 0)
            {
                enemy.GroupAlive = true;
                break;
            }
        }
        if (enemy.GroupAlive == false)
        {
            // här sätts GroupOfEnemies marker till ett blanksteg i stället för dess ursprungliga värde.
            enemy.Marker = " ";
            Map.mapLayout[enemy.MapPositioni, enemy.MapPositionj] = " ";
            // GroupOfEnemies flyttas längst ned till vänster för att inte störa någon igen.
            enemy.MapPositioni = 38;
            enemy.MapPositionj = 1;
            BattleWon();
        }
    }
    
    private static void battleRuns(GroupOfEnemies enemy)
    {
        // sätter värdet på battle over till false eftersom förra battle satte till true;
        battleOver = false;
        while (battleOver == false)
        {
            TurnQueList.Add(TurnQueList[0]);
            TurnQueList.RemoveAt(0);

            updatePrintInfo(enemy);

            // Vem ska agera??
            if (TurnQueList[0].Name == Program.Hero.Name)
            {
                playerMenu(enemy);
            }
            else
            {
                enemyAction(enemy, TurnQueList[0]);
            }
            // Har någon dött?
            isEnemyDead(enemy);
            updatePrintInfo(enemy);
            isBattleOver(enemy);

        }

    }
       
    // Methods for player
    private static void playerMenu(GroupOfEnemies enemy)
    {
        if (Program.Hero.HP < 26)
            "VARNING! Du har lite HP kvar!".Position(30, 20, "Magenta");
        "Meny för val: ".Position(30, 10, "Magenta");
        "1. Fysisk attack.".Position(30, 11, "White");
        "2. Attack med magi.".Position(30, 12, "White");
        ("3. Drick helande dryck. " + Program.Hero.NumberOfHealingPotions + " st kvar").Position(30, 13, "White");
        ("4. Drick magisk dryck. " + Program.Hero.NumberOfMagicPotions + " st kvar").Position(30, 14, "White");
        "-> ".Position(30, 15, "White");

        while (true)
        {
            Console.SetCursorPosition(33, 15);

            string playerMenuchoice = Convert.ToString(Console.ReadLine());
            Graphics.fillBattleLine3020.Position(0, 17, "Cyan");
            if (playerMenuchoice == "1")
            {
                playerWeaponAttack(enemy);
                break;
            }
            else if (playerMenuchoice == "2")
            {
                playerMagicAttack(enemy);
                break;
            }
            else if (playerMenuchoice == "3")
            {
                playerDrinksHP();
                break;
            }
            else if (playerMenuchoice == "4")
            {
                playerDrinksMP();
                break;
            }
            else
            {
                "Du måste ange ett nummer mellan 1-4".Position(33, 17, "White");
                Graphics.fillMenuInBattle.Position(33, 15, "White");
            }
        }
    }
    private static void playerMagicAttack(GroupOfEnemies enemy)
    {
        "Vilket fiende-nummer vill du attackera? -> ".Position(30, 16, "Cyan");
        int target;
        string stringTarget = "";
        while (true)
        {
            Console.SetCursorPosition(73, 16);
            stringTarget = Console.ReadLine();
            Graphics.fillBattleLine3020.Position(0, 17, "Cyan");
            if ((int.TryParse(stringTarget, out target)) && (target > 0 && target <= enemy.EnemyList.Count))
            {
                break;
            }
            else
            {
                "Du måste välja ett nummer som står framför en av fienderna!".Position(30, 17, "White");
                Graphics.fillMenuInBattle.Position(73, 16, "Cyan");
            }
        }
        Graphics.HeroAttack();
        int hitPoints = Program.Hero.PlayerMagicAttack(Program.Hero.Element, enemy.EnemyList[(target - 1)]);
        enemy.EnemyList[(target - 1)].HP -= hitPoints;
        playerAttackOutcome(hitPoints);
    }
    private static void playerWeaponAttack(GroupOfEnemies enemy)
    {
        "Vilket fiende-nummer vill du attackera? -> ".Position(30, 16, "Cyan");
        int target;
        string stringTarget = "";
        while (true)
        {
            Console.SetCursorPosition(73, 16);
            stringTarget = Console.ReadLine();
            Graphics.fillBattleLine3020.Position(0, 17, "Cyan");
            if ((int.TryParse(stringTarget, out target)) && (target > 0 && target <= enemy.EnemyList.Count))
            {
                break;
            }
            else
            {
                "Du måste välja ett nummer som står framför en av fienderna!".Position(30, 17, "White");
                Graphics.fillMenuInBattle.Position(73, 16, "Cyan");
            }

        }
        Graphics.HeroAttack();
        int hitPoints = Program.Hero.PlayerWeaponAttack(Program.Hero.Strength);
        enemy.EnemyList[(target - 1)].HP -= hitPoints;
        playerAttackOutcome(hitPoints);
        
    }
    private static void playerDrinksHP()
    {
        Program.Hero.playerDrinksHP();
        
        Console.ReadKey();
    }
    private static void playerDrinksMP()
    {
        Program.Hero.playerDrinksMP();

        Console.ReadKey();
    }
    private static void playerAttackOutcome(int hitpoints)
    {
        ("Din attack gjorde " + hitpoints + " HP i skada!").Position(30, 20, "Green");
        Console.ReadKey();
    }
    
    
    // Methods for enemies
    private static void enemyAction(GroupOfEnemies enemy, Characters noll) // Characters noll är TurnQueList[0]
    {
        foreach (Enemies e in enemy.EnemyList)
        {
            //string namn = e.Name;

            if (e.Name == noll.Name)
            {
                if (e.Alive == false) { }
                else
                    enemyAttack(e);
            }
            
        }
    }
    private static void enemyAttack(Enemies e)
    {
        //random för att kolla vad fienden gör
        Random rand = new Random();
        int action = rand.Next(1, 6);

        if (action == 1)
        {
            (e.Name + " skriker argt på dig men anfaller inte...").Position(30, 20, "White");
            Console.ReadLine();
        }
        else if (e.Element == "inget")
            enemyWeaponAttack(e);
        else
            enemyMagicAttack(e);  
        

        
    }
    private static void enemyWeaponAttack(Enemies e)
    {
        Graphics.fillBattleLine3020.Position(0, 20, "Cyan");
        (e.Name + " anfaller med sitt vapen!").Position(30, 20, "White");
        Console.ReadKey();
        Graphics.EnemyAttack(e);
        int hitPoints = e.WeaponAttacks(e);
        Program.Hero.HP -= hitPoints;
        enemyAttackOutcome(hitPoints, e);
    }
    private static void enemyMagicAttack(Enemies e)
    {
        Graphics.fillBattleLine3020.Position(0, 20, "Cyan");
        (e.Name + " anfaller med en " + e.Element + "-attack!").Position(30, 20, "White");
        Console.ReadKey();
        Graphics.EnemyAttack(e);
        int hitPoints = e.MagicAttacks(e);
        Program.Hero.HP -= hitPoints;
        enemyAttackOutcome(hitPoints, e);
    }

    private static void enemyAttackOutcome(int hitpoints, Enemies e)
    {
        Graphics.fillBattleLine3020.Position(0, 20, "Cyan");
        (e.Name + " gjorde " + hitpoints + " HP i skada!").Position(30, 20, "White");
        Console.ReadKey();
    }
    // Common methods
    public static void FirstBattle()
    {
        Battle.CheckIfBattle(Program.Hero, Program.PrisonGuard);
    }
}

