using System;
using System.Collections.Generic;

public class Enemies : Characters
{
    // Fields
   

    // Properties : Characters
    public override string Name { get; set; }
    public override string Marker { get; set; }
    public override int Strength { get; set; }
    public override int HP
    {
        get
        {
            if (hp <= 0)
                return 0;
            else
                return hp;
        }
        set
        {
            hp = value;
        }
    }
    public override int MP { get; set; }
    public override string Element { get; set; }
    public override int MapPositioni { get; set; }
    public override int MapPositionj { get; set; }
    public override int PrevMapPositioni { get; set; }
    public override int PrevMapPositionj { get; set; }
    // Properties
    public bool Alive = true;
    
    // Constructor
    public Enemies(string _name, string _marker, int _strength, int _hp, int _mp, string _element)
    {
        Name = _name;
        Marker = _marker;
        Strength = _strength;
        HP = _hp;
        MP = _mp;
        Element = _element;
        Alive = true;
    }

    // Methods
    public override void Action()
    { 
    
    }
    public int WeaponAttacks(Enemies enemy)
    {
        Random rand = new Random();
        int damage = enemy.Strength + rand.Next(5, 11);

        return damage;
    }
    public int MagicAttacks(Enemies enemy)
    {
        Random rand = new Random();
        int damage = rand.Next(5, 11);

        if (enemy.Element == Program.Hero.Element)
            damage = 2;
        else if (enemy.Element != Program.Hero.Element)
            damage += 10;
        
        return damage;
    }
   

}

