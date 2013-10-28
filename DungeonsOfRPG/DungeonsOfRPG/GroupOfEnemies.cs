using System;
using System.Collections.Generic;

class GroupOfEnemies
{
    private bool moveOk = false;
    public bool GroupAlive = true;
    // Propterties
    public string Marker { get; set; }
    public List<Enemies> EnemyList { get; set; }
    public int MapPositioni { get; set; }
    public int MapPositionj { get; set; }
    public int PrevMapPositioni { get; set; }
    public int PrevMapPositionj { get; set; }
    public bool PlayerClose { get; set; }
    public int Area { get; set; }
    // Constructor
    public GroupOfEnemies(string _marker, int _posI, int _posJ, int _area, List<Enemies> _enemyList)
    {
        Marker = _marker;
        EnemyList = _enemyList;
        MapPositioni = _posI;
        PrevMapPositioni = _posI;
        MapPositionj = _posJ;
        PrevMapPositionj = _posJ;
        PlayerClose = false;
        Area = _area;
    }

    // Methods
    public void HeroClose(GroupOfEnemies goe)
    { 
    
    }
    public void Move(GroupOfEnemies goe) 
    {
        
        goe.PlayerClose = false;
        goe.PrevMapPositioni = goe.MapPositioni;
        goe.PrevMapPositionj = goe.MapPositionj;

        // Först känner GroupOfEnemies av om Hero är tillräckling nära
        #region
        if (
            // nedanför && höger
            ((goe.MapPositioni + 3 == Program.Hero.MapPositioni || goe.MapPositioni + 2 == Program.Hero.MapPositioni || goe.MapPositioni + 1 == Program.Hero.MapPositioni) && (goe.MapPositionj + 3 == Program.Hero.MapPositionj || goe.MapPositionj + 2 == Program.Hero.MapPositionj || goe.MapPositionj + 1 == Program.Hero.MapPositionj))
            // ovanför && vänster
         || ((goe.MapPositioni - 3 == Program.Hero.MapPositioni || goe.MapPositioni - 2 == Program.Hero.MapPositioni || goe.MapPositioni - 1 == Program.Hero.MapPositioni) && (goe.MapPositionj - 3 == Program.Hero.MapPositionj || goe.MapPositionj - 2 == Program.Hero.MapPositionj || goe.MapPositionj - 1 == Program.Hero.MapPositionj))
            // nedanför && vänster
         || ((goe.MapPositioni + 3 == Program.Hero.MapPositioni || goe.MapPositioni + 2 == Program.Hero.MapPositioni || goe.MapPositioni + 1 == Program.Hero.MapPositioni) && (goe.MapPositionj - 3 == Program.Hero.MapPositionj || goe.MapPositionj - 2 == Program.Hero.MapPositionj || goe.MapPositionj - 1 == Program.Hero.MapPositionj))
            // ovanför && höger
         || ((goe.MapPositioni - 3 == Program.Hero.MapPositioni || goe.MapPositioni - 2 == Program.Hero.MapPositioni || goe.MapPositioni - 1 == Program.Hero.MapPositioni) && (goe.MapPositionj + 3 == Program.Hero.MapPositionj || goe.MapPositionj + 2 == Program.Hero.MapPositionj || goe.MapPositionj + 1 == Program.Hero.MapPositionj))
            // bara nedanför   
         || ((goe.MapPositioni + 4 == Program.Hero.MapPositioni || goe.MapPositioni + 3 == Program.Hero.MapPositioni || goe.MapPositioni + 2 == Program.Hero.MapPositioni) && (goe.MapPositionj == Program.Hero.MapPositionj))
            // bara ovanför
         || ((goe.MapPositioni + 4 == Program.Hero.MapPositioni || goe.MapPositioni - 3 == Program.Hero.MapPositioni || goe.MapPositioni - 2 == Program.Hero.MapPositioni) && (goe.MapPositionj == Program.Hero.MapPositionj))
            // bara höger
         || ((goe.MapPositioni == Program.Hero.MapPositioni) && (goe.MapPositionj + 4 == Program.Hero.MapPositionj || goe.MapPositionj + 3 == Program.Hero.MapPositionj || goe.MapPositionj + 2 == Program.Hero.MapPositionj))
            // bara vänster
         || ((goe.MapPositioni == Program.Hero.MapPositioni) && (goe.MapPositionj - 4 == Program.Hero.MapPositionj || goe.MapPositionj - 3 == Program.Hero.MapPositionj || goe.MapPositionj - 2 == Program.Hero.MapPositionj))
         )
        #endregion
        // slut på lång och krånglig if-sats
        
            // Om Hero är nära så...
        {
            //kolla om det är direktkontakt
            #region
            foreach (var g in Program.EnemyGroups)
            {
                Battle.CheckIfBattle(Program.Hero, g);
            }
            #endregion

            // flytta GroupOfEnemies
            moveOk = false;
            
            // kolla om player står rakt åt något håll
            #region
            // rakt nedanför
            if (goe.MapPositioni < Program.Hero.MapPositioni && goe.MapPositionj == Program.Hero.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni + 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni++;
            }
            // rakt ovanför
            else if (goe.MapPositioni > Program.Hero.MapPositioni && goe.MapPositionj == Program.Hero.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni - 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni--;
            }
            // rakt till höger
            else if (goe.MapPositioni == Program.Hero.MapPositioni && goe.MapPositionj < Program.Hero.MapPositionj)
            {
                checkIfMoveIsOk(MapPositioni, (MapPositionj + 1));
                if (moveOk == true)
                    goe.MapPositionj++;
            }
            // rakt till vänster
            else if (goe.MapPositioni == Program.Hero.MapPositioni && goe.MapPositionj > Program.Hero.MapPositionj)
            {
                checkIfMoveIsOk(MapPositioni, (MapPositionj - 1));
                if (moveOk == true)
                    goe.MapPositionj--;
            }
            #endregion

            // Om spelaren står Diagonalt....
            #region
            // ner till höger
            if (Program.Hero.MapPositioni > goe.MapPositioni && Program.Hero.MapPositionj > goe.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni + 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni++;
                if (moveOk == false)
                {
                    checkIfMoveIsOk(MapPositioni, (MapPositionj + 1));
                    if (moveOk == true)
                        goe.MapPositionj++;
                }
            }

            // upp till höger
            else if (Program.Hero.MapPositioni < goe.MapPositioni && Program.Hero.MapPositionj > goe.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni - 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni--;
                if (moveOk == false)
                {
                    checkIfMoveIsOk(MapPositioni, (MapPositionj + 1));
                    if (moveOk == true)
                        goe.MapPositionj++;
                }
            }

            // upp till vänster
            else if (Program.Hero.MapPositioni < goe.MapPositioni && Program.Hero.MapPositionj < goe.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni - 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni--;
                if (moveOk == false)
                {
                    checkIfMoveIsOk(MapPositioni, (MapPositionj - 1));
                    if (moveOk == true)
                        goe.MapPositionj--;
                }
            }

            // ner till vänster
            else if (Program.Hero.MapPositioni > goe.MapPositioni && Program.Hero.MapPositionj < goe.MapPositionj)
            {
                checkIfMoveIsOk((MapPositioni + 1), MapPositionj);
                if (moveOk == true)
                    goe.MapPositioni++;
                if (moveOk == false)
                {
                    checkIfMoveIsOk(MapPositioni, (MapPositionj - 1));
                    if (moveOk == true)
                        goe.MapPositionj--;
                }
            }
            #endregion

            PlayerClose = true;
        }
    } // slut på Move();
    
    private void checkIfMoveIsOk(int i, int j)
    {
        if (Map.mapLayout[i, j] == " ")
            moveOk = true;
    }

}




//// Först känner GroupOfEnemies av om Hero är tillräckling nära
//        if (
//            // nedanför && höger
//            ((MapPositioni + 3 > Program.Hero.MapPositioni || MapPositioni + 2 > Program.Hero.MapPositioni) && (MapPositionj + 3 < Program.Hero.MapPositionj || MapPositionj + 2 < Program.Hero.MapPositionj))
//            // ovanför && vänster
//         || ((MapPositioni - 3 < Program.Hero.MapPositioni || MapPositioni - 2 < Program.Hero.MapPositioni) && (MapPositionj - 3 > Program.Hero.MapPositionj || MapPositionj - 2 > Program.Hero.MapPositionj))
//            // nedanför && vänster
//         || ((MapPositioni + 3 > Program.Hero.MapPositioni || MapPositioni + 2 > Program.Hero.MapPositioni) && (MapPositionj - 3 > Program.Hero.MapPositionj || MapPositionj - 2 > Program.Hero.MapPositionj))
//            // ovanför && höger
//         || ((MapPositioni - 3 < Program.Hero.MapPositioni || MapPositioni - 2 < Program.Hero.MapPositioni) && (MapPositionj + 3 < Program.Hero.MapPositionj || MapPositionj + 2 < Program.Hero.MapPositionj))
//            // bara nedanför   
//         || ((MapPositioni + 3 > Program.Hero.MapPositioni || MapPositioni + 2 > Program.Hero.MapPositioni) && (MapPositionj == Program.Hero.MapPositionj))
//            // bara ovanför
//         || ((MapPositioni - 3 < Program.Hero.MapPositioni || MapPositioni - 2 < Program.Hero.MapPositioni) && (MapPositionj == Program.Hero.MapPositionj))
//            // bara höger
//         || ((MapPositioni == Program.Hero.MapPositioni) && (MapPositionj + 3 > Program.Hero.MapPositionj || MapPositionj + 2 > Program.Hero.MapPositionj))
//            // bara vänster
//         || ((MapPositioni == Program.Hero.MapPositioni) && (MapPositionj + 3 > Program.Hero.MapPositionj || MapPositionj - 2 > Program.Hero.MapPositionj))
//         ) // slut på lång och krånglig if-sats

////////////////////////////////////

//// kolla om spelaren står diagonalt...
//            // nedanför && höger
//            if (goe.MapPositioni + 1 == Program.Hero.MapPositioni && goe.MapPositionj + 1 == Program.Hero.MapPositionj)
//                goe.MapPositioni++;
//                // ovanför && vänster
//            else if (goe.MapPositioni - 1 == Program.Hero.MapPositioni && goe.MapPositionj - 1 == Program.Hero.MapPositionj)
//                goe.MapPositioni--;
//                // nedanför && vänster
//            else if (goe.MapPositioni + 1 == Program.Hero.MapPositioni && goe.MapPositionj - 1 == Program.Hero.MapPositionj)
//                goe.MapPositionj++;
//                // ovanför && höger
//            else if (goe.MapPositioni - 1 == Program.Hero.MapPositioni && goe.MapPositionj + 1 == Program.Hero.MapPositionj)
//                goe.MapPositionj--;
//            else
//            {
//                // kolla om spelaren står 2 rutor bort
//                if (goe.MapPositioni + 2 == Program.Hero.MapPositioni)
//                    goe.MapPositioni++;
//                else if (goe.MapPositioni - 2 == Program.Hero.MapPositioni)
//                    goe.MapPositioni--;
//                else if (goe.MapPositionj + 2 == Program.Hero.MapPositionj)
//                    goe.MapPositionj++;
//                else if (goe.MapPositionj - 2 == Program.Hero.MapPositionj)
//                    goe.MapPositionj--;
//                else
                
//                    if
            