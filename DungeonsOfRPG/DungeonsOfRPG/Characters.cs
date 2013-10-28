using System;
using System.Collections.Generic;

public abstract class Characters
{
    // Fields
    protected string name;
    protected string marker;
    protected int mapPositioni;
    protected int mapPositionj;
    

    protected int hp;
    
    // Properties
    public abstract string Name { get; set; }
    public abstract string Marker { get; set; }
    public abstract int Strength { get; set; }
    public abstract int HP { get; set; }
    public abstract int MP { get; set; }
    public abstract string Element { get; set; }
    public abstract int MapPositioni { get; set; }
    public abstract int MapPositionj { get; set; }
    public abstract int PrevMapPositioni { get; set; }
    public abstract int PrevMapPositionj { get; set; }
    
    
    // Constructor
    

    // Methods
    public abstract void Action();
   

}

