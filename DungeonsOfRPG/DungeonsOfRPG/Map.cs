using System;
using System.Collections.Generic;
using System.Threading;

public class Map
{
    // Fields

    // Properties
    
    
    // mapLayout är 40 x 90 rutor
    public static string[,] mapLayout = {
    #region
                                                //      ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠                                                                                                                                      ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠                                                               ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠

    {"╔","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╦","═","═","═","═","═","═","═","═","═","═","═","═","═","╦","═","═","═","═","═","╦","╦","═","═","═","═","═","═","═","═","═","═","╦","═","═","═","═","═","═","═","═","═","═","═","═","═","╦","╦","═","═","═","╗",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╠","╣"," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╠","╣"," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╠","╣"," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╔","═","═","═","═","╗"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╠","╣"," "," "," "," "," ","╔","═","═","═","═","╣"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," ","╔","═","═","═","═","═","╗"," ","╔","═","═","═","═","═","╗"," "," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╠","╣"," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," ","║"," "," "," "," "," ","║"," ","║"," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," ","╚","═","═","═","═","═","╬","═","╬","═","═","═","═","═","╝"," "," "," "," "," ","╠","╣"," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╬","═","═"," ","║",},
    {"║"," "," "," "," ","║"," "," "," "," "," ","║"," ","║"," "," "," "," "," ","║"," "," "," "," ","╔","═","╝"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," ","║"," "," "," "," "," ","║"," ","║"," "," "," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╚","╝"," "," "," "," "," ","║"," "," "," "," ","╚","═","═","═","═","═","═","═","═"," "," "," ","═","═","╬","╣"," "," "," ","║",},
    {"║"," "," "," "," ","╚","═","╗"," ","╔","═","╝"," ","╚","═","╗"," ","╔","═","╝"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," "," "," ","║"," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," ","═","═","╣",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," "," "," ","║"," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","╔","═","╦","═","╦","═","╦","═","╦","═","╦","═","═","═","═","╦","═","╦","═","═","═","╦","═","╦","╗"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","╚","═","═","═","═","═","╝"," ","║"," "," "," "," "," "," ","╚","═","═","═","═","═","═","╝"," "," "," "," "," ","║"," ","║"," ","║"," ","║"," ","║"," ","║"," "," "," "," ","║"," ","║"," "," "," ","║"," ","╠","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","╔","═","═","═","═","═","═","═","═"," "," "," "," ","═","═","═","╬","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","╔","═","═","═","═","═","═","═","╝"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╠","═","═"," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," ","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╗"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","║"," ","║"," "," "," "," ","║"," ","║"," "," "," "," ","║"," ","║"," "," ","╠","║"," "," "," "," "," "," ","╠","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╬","╣"," "," "," ","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","╚","═","═","═","╩","═","╩","═","═","═","═","╩","═","╩","═","═","═","═","╩","═","╩","═","═","╩","╝"," "," "," "," "," "," ","╚","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╝"," "," "," ","║",},
    {"║"," ","╔","═","═","═","═","╗"," "," "," "," "," ","║"," "," "," "," ","║"," ","║"," ","║"," ","║"," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," ","║"," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," ","╬","═","╬","═","╬","═","╬","═","╬"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," ","║"," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," ","║"," ","║"," ","║"," ","║"," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╔","═","═","═","═"," "," "," ","═","═","═","═","╗"," "," "," "," "," "," ","╔","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╦","╣",},
    {"║"," ","╚","═","═"," ","═","╝"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","╠","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","╩","║",},
    {"║"," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," ","╔","═","═","═","═","╗"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," ","║"," "," "," "," ","║"," "," "," "," "," ","╚","═","═","═","═","═","═","═"," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","╔","═","═","═","═","═","═","═","═","═","═","╗"," "," "," ","║",},
    {"║"," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," ","║"," "," "," ","║",},
    {"║"," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","╔","═","═","═","═","╗"," ","║"," "," "," ","║",},
    {"║"," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","╠","═","═","═","╦","═","╦","═","═","═","═","═","╣"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","║"," "," "," "," ","║"," ","║"," "," "," ","║",},
    {"║"," ","╚","═","═","═","═","╗"," ","╔","═","═","═","═","═","═","═","═"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","║"," ","═","═","═","╝"," ","║"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","║"," "," "," "," "," "," ","║"," "," "," ","║",},
    {"║"," "," "," "," "," "," ","║"," ","║"," ","╔","═","═","═","═","═","═"," "," ","╔","═","═","═","═","═"," "," ","║"," "," ","╔","═","═","═","═","╗"," "," "," ","╔","═","═","═","═","╗"," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," ","╚","═","═","═","═","═","═","╝"," "," "," ","║",},
    {"╠","═","═","═","═","╗"," ","║"," ","║"," ","║"," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," ","║"," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," "," "," "," ","║"," ","║"," ","║"," ","╚","═","═","═","═","═","═"," "," ","╚","═","═","═","═","═","═","═","╣"," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," "," "," "," ","║"," ","║"," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," ","╚","═","═","═","═"," "," "," ","═","═","═","═","╝"," "," "," "," "," "," ","║"," "," "," "," "," ","╚","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╣",},
    {"║"," "," "," "," ","║"," ","║"," ","╚","═","═","═","═","═","═","═"," "," "," "," ","═","═","═","═","═","═","═","╝"," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," ","═","╣"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," ","║"," "," "," ","║"," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","║",},
    {"╚","═","═","═","═","╩","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╩","═","═","═","═","╣","╬","═","╬","╠","═","═","═","═","╩","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╝",}
    };
    //      ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠                                                                                                                                      ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠                                                                                                              ╚ ╔ ╗ ╝ ╬ ═ ║ ╦ ╩ ╣ ╠
    #endregion
    
    // Constructor
    public Map()
    { 
    
    }
    // Methods

    // Anropas från class Item - constructorn
    public void GetItemPositions(int i, int j, string marker)
    {
        mapLayout[i, j] = marker;
    }
    private void getAllPositions()
    {
        // ta reda på fiendernas positioner
        foreach (var g in Program.EnemyGroups)
        {
            groupsPositionToMap(g.MapPositioni, g.MapPositionj, g.PrevMapPositioni, g.PrevMapPositionj, g.Marker);
        }
        // ta reda på spelarens position
        playerPositionToMap(Program.Hero.MapPositioni, Program.Hero.MapPositionj, Program.Hero.PrevMapPositioni, Program.Hero.PrevMapPositionj);
    }
    private void playerPositionToMap(int playeri, int playerj, int previ, int prevj)
    {
        mapLayout[previ, prevj] = " ";
        mapLayout[playeri, playerj] = Program.Hero.Marker;
    }
    private void groupsPositionToMap(int onei, int onej, int previ, int prevj, string marker)
    {
        mapLayout[previ, prevj] = " ";
        mapLayout[onei, onej] = marker;
    }
    // skriv ut info på högra sidan av skärmen
    private void printInfoRightSide()
    {
        PIRSitems();
        PIRScontrols();
        PIRSplayerproperty();
    }
    private void PIRSitems()
    {
        int x = 11;
        for (int i = 11; i < 25; i++)
        { 
    
            Graphics.fillEmptyItems.Position(95, i, "Green"); 
        }
        
        foreach (string f in Program.Hero.PlayerItems)
        {
            if (f == "Spelarens föremål:")
                (f).Position(95, x, "Green");
            else
            (f).Position(95, x, "Yellow");
            x++;
        }
    }
    private void PIRScontrols()
    {
        "KONTROLLER:   Upp W".Position(100, 2, "Magenta");
        "     Vänster A      Höger D".Position(100, 3, "Magenta");
        "              Ned S".Position(100, 4, "Magenta");
        " Ta föremål: I".Position(100, 6, "Magenta");
        " Drick Helande dryck: H".Position(100, 7, "Magenta");
        " Drick Magisk dryck: M".Position(100, 8, "Magenta");
    }
    private void PIRSplayerproperty()
    {
        int x = 11;
        for (int i = 11; i < 25; i++)
        {
            Graphics.fillEmptyEgenskaper.Position(118, i, "DarkYellow");
        }
        
        "Egenskaper: ".Position(118, x, "Green");
        x++;
        ("Namn: " + Program.Hero.Name).Position(118, x, "Green");
        x++;
        ("HP: " + Program.Hero.HP + " / " + Program.Hero.MaxHP).Position(118, x, "Green");
        x++;
        ("MP: " + Program.Hero.MP + " / " + Program.Hero.MaxMP).Position(118, x, "Green");
        x++;
        ("Styrka: " + Program.Hero.Strength).Position(118, x, "Green");
    }
    
    // events for player
    private void checkAreaEvents()
    {
        EventArea1();
        EventArea2();
        EventArea3();
        EventArea4();
        EventArea5();
        EventArea6();
        EventArea7();
        EventArea8();
        EventArea9();
        EventArea10();
        EventArea11();
        EventArea12();

    }
    private void checkIfAreasIsTrue()
    {
        if (Graphics.printArea1 == true)
            Graphics.printAre1a();

        if (Graphics.printArea2 == true)
            Graphics.printAre2a();

        if (Graphics.printArea3 == true)
            Graphics.printAre3a();

        if (Graphics.printArea4 == true)
            Graphics.printAre4a();

        if (Graphics.printArea5 == true)
            Graphics.printAre5a();

        if (Graphics.printArea6 == true)
            Graphics.printAre6a();

        if (Graphics.printArea7 == true)
            Graphics.printAre7a();

        if (Graphics.printArea8 == true)
            Graphics.printAre8a();

        if (Graphics.printArea9 == true)
            Graphics.printAre9a();

        if (Graphics.printArea10 == true)
            Graphics.printAre10a();

        if (Graphics.printArea11 == true)
            Graphics.printAre11a();

        if (Graphics.printArea12 == true)
            Graphics.printAre12a();

        //if (Graphics.printArea13 == true)
        //    Graphics.printAre13a();

        //if (Graphics.printArea14 == true)
        //    Graphics.printAre14a();

        //if (Graphics.printArea15 == true)
        //    Graphics.printAre15a();
    }
    private void EventArea1()
    {
        if (Program.Hero.MapPositionj == 69)
        {
            if ((Program.Hero.MapPositioni == 37 || Program.Hero.MapPositioni == 38) && Graphics.printArea1 == true)
            {
                Graphics.printArea1 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea2()
    {
        if (Program.Hero.MapPositionj == 69)
        {
            if ((Program.Hero.MapPositioni == 21 || Program.Hero.MapPositioni == 22) && Graphics.printArea2 == true)
            {
                Graphics.printArea2 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea3()
    {
        if (Program.Hero.MapPositioni == 33)
        {
            if ((Program.Hero.MapPositionj == 37 || Program.Hero.MapPositionj == 38 || Program.Hero.MapPositionj == 39) && Graphics.printArea3 == true)
            {
                Graphics.printArea3 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea4()
    {
        if (Program.Hero.MapPositioni == 33)
        {
            if ((Program.Hero.MapPositionj >= 46 && Program.Hero.MapPositionj <= 48) && Graphics.printArea4 == true)
            {
                Graphics.printArea4 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 31)
        {
            if ((Program.Hero.MapPositionj >= 62 && Program.Hero.MapPositionj <= 67) && Graphics.printArea4 == true)
            {
                Graphics.printArea4 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea5()
    {
        if (Program.Hero.MapPositioni == 20)
        {
            if ((Program.Hero.MapPositionj >= 62 && Program.Hero.MapPositionj <= 67) && Graphics.printArea5 == true)
            {
                Graphics.printArea5 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 30)
        {
            if ((Program.Hero.MapPositionj >= 62 && Program.Hero.MapPositionj <= 67) && Graphics.printArea5 == true)
            {
                Graphics.printArea5 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositionj == 50)
        {
            if ((Program.Hero.MapPositioni == 21 || Program.Hero.MapPositioni == 22) && Graphics.printArea5 == true)
            {
                Graphics.printArea5 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea6()
    {
        if (Program.Hero.MapPositionj == 30)
        {
            if ((Program.Hero.MapPositioni >= 29 && Program.Hero.MapPositioni <= 32) && Graphics.printArea6 == true)
            {
                Graphics.printArea6 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 25)
        {
            if ((Program.Hero.MapPositionj >= 1 && Program.Hero.MapPositionj <= 30) && Graphics.printArea6 == true)
            {
                Graphics.printArea6 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea7()
    {
        if (Program.Hero.MapPositioni == 17)
        {
            if ((Program.Hero.MapPositionj >= 1 && Program.Hero.MapPositionj <= 30) && Graphics.printArea7 == true)
            {
                Graphics.printArea7 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 26)
        {
            if ((Program.Hero.MapPositionj >= 1 && Program.Hero.MapPositionj <= 30) && Graphics.printArea7 == true)
            {
                Graphics.printArea7 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea8()
    {
        if ((Program.Hero.MapPositionj == 8 && Program.Hero.MapPositioni == 16) && Graphics.printArea8 == true)
        {
            Graphics.printArea8 = false;
            AfterBattle();
        }
    }
    private void EventArea9()
    {
        if (Program.Hero.MapPositionj == 58)
        {
            if ((Program.Hero.MapPositioni == 9 || Program.Hero.MapPositioni == 10) && Graphics.printArea9 == true)
            {
                Graphics.printArea9 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 16)
        {
            if ((Program.Hero.MapPositionj >= 1 && Program.Hero.MapPositionj <= 6) && Graphics.printArea9 == true)
            {
                Graphics.printArea9 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 16)
        {
            if ((Program.Hero.MapPositionj >= 10 && Program.Hero.MapPositionj <= 12) && Graphics.printArea9 == true)
            {
                Graphics.printArea9 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 18)
        {
            if ((Program.Hero.MapPositionj >= 32 && Program.Hero.MapPositionj <= 36) && Graphics.printArea9 == true)
            {
                Graphics.printArea9 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea10()
    {
        if ((Program.Hero.MapPositionj == 45 && Program.Hero.MapPositioni == 6) && Graphics.printArea10 == true)
        {
            Graphics.printArea10 = false;
            AfterBattle();
        }
    }
    private void EventArea11()
    {
        if (Program.Hero.MapPositionj == 37)
        {
            if ((Program.Hero.MapPositioni == 15 || Program.Hero.MapPositioni == 16) && Graphics.printArea11 == true)
            {
                Graphics.printArea11 = false;
                AfterBattle();
            }
        }
    }
    private void EventArea12()
    {
        if (Program.Hero.MapPositionj == 59)
        {
            if ((Program.Hero.MapPositioni == 9 || Program.Hero.MapPositioni == 10) && Graphics.printArea12 == true)
            {
                Graphics.printArea12 = false;
                AfterBattle();
            }
        }
        if (Program.Hero.MapPositioni == 19)
        {
            if ((Program.Hero.MapPositionj >= 62 && Program.Hero.MapPositionj <= 67) && Graphics.printArea12 == true)
            {
                Graphics.printArea12 = false;
                AfterBattle();
            }
        }
    }
   
    
    public void CheckEventForHero()
    {
        checkAreaEvents();

        if (Program.Hero.MapPositioni == 7 && Program.Hero.MapPositionj == 45)
            bossDoor();
        if (Program.Hero.MapPositioni == 38 && Program.Hero.MapPositionj == 38)
            exitDoor();
        if (Program.Hero.MapPositioni == 39 && Program.Hero.MapPositionj == 38)
            youWon();
  

    }
    private void bossDoor()
    {
        char open = ' ';
        if (Map.mapLayout[6, 45] == "═")
        {
            Graphics.FillInfoSquare();
            "Låst dörr, tryck O för att öppna.".Position(95, 27, "Cyan");
            open = Convert.ToChar(Console.ReadKey().KeyChar);
        }
        
        if (open == 'o' && Program.Hero.PlayerItems.Contains("Nyckel av platina"))
        { 
            Map.mapLayout[6,45] = " ";
            Graphics.FillInfoSquare();
            "Med din nyckel av platina öppnar du".Position(95, 27, "Cyan");
            "dörren till slutbossen!".Position(95, 28, "Cyan");
            Program.Hero.PlayerItems.Remove("Nyckel av platina");
            Graphics.PressC().Position(95, 30, "DarkCyan");
            Graphics.DoPressC();
            // AfterBattle för att uppdatera kartan på skärmen
            AfterBattle();

        }
        else if (open == 'o')
        {
            Graphics.FillInfoSquare();
            "Du måste ha en nyckel av platina".Position(95, 27, "Cyan");
            "för att kunna öppna.".Position(95, 28, "Cyan");
            Graphics.PressC().Position(95, 30, "DarkCyan");
            Graphics.DoPressC();
        }
        else
        { }
    }
    private void exitDoor()
    {
        char open = ' ';
        if (Map.mapLayout[39, 38] == "═")
        {
            Graphics.FillInfoSquare();
            "Denna dörr tar dig till friheten.".Position(95, 27, "Cyan");
            "Tryck O för att öppna.".Position(95, 28, "Cyan");
            open = Convert.ToChar(Console.ReadKey().KeyChar);
        }
        if (open == 'o' && Program.Hero.PlayerItems.Contains("Nyckel av adamant"))
        {
            Map.mapLayout[39, 38] = " ";
            Graphics.FillInfoSquare();
            "Du öppnade dörren till friheten.".Position(95, 27, "Green");
            Graphics.PressC().Position(95, 29, "DarkCyan");
            Graphics.DoPressC();
            // AfterBattle för att uppdatera kartan på skärmen
            AfterBattle();

        }
        else if (open == 'o')
        {
            Graphics.FillInfoSquare();
            "Du måste ha en nyckel av adamant".Position(95, 27, "Cyan");
            "för att kunna öppna.".Position(95, 28, "Cyan");
            Graphics.PressC().Position(95, 30, "DarkCyan");
            Graphics.DoPressC();
        }
        else
        { }
    }
    private void youWon()
    {
        Console.Clear();
        "Du har äntligen lyckats att fly från fängelsehålan, välkommen att spela igen!!!".Position(20, 10, "Green");
        Thread.Sleep(3000);
        Graphics.PressC().Position(20, 13, "DarkCyan");
        Graphics.DoPressC();
        Console.SetCursorPosition(20, 15);
        Environment.Exit(0);
        
    }
    
    public void PrintMap()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 90; j++)
            {
                Console.Write(mapLayout[i, j]);
                if (j == 90 - 1)
                    Console.Write("\n");
            }
        }
        printItems();
        checkIfAreasIsTrue(); // kommentera ut denna om hela kartan ska synas

        "HÄNDELSER:".Position(100, 25, "White");
    }
    
    public void AfterBattle()
    {
        Console.Clear();
        //TODOMN
        
        PrintCharacters();
        //printItems(); har flyttat denna till printmap
        printInfoRightSide();
        PrintMap();
        
    }
    private void PrintCharacters()
    { 
        " ".Position(Program.Hero.PrevMapPositionj, Program.Hero.PrevMapPositioni, "Cyan");
        (Program.Hero.Marker).Position(Program.Hero.MapPositionj, Program.Hero.MapPositioni, "Green");

        foreach (GroupOfEnemies g in Program.EnemyGroups)
        {
            switch (g.Area)
            {
                case 1:
                    if (Graphics.printArea1 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 2:
                    if (Graphics.printArea2 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 3:
                    if (Graphics.printArea3 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 4:
                    if (Graphics.printArea4 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 5:
                    if (Graphics.printArea5 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 6:
                    if (Graphics.printArea6 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 7:
                    if (Graphics.printArea7 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 8:
                    if (Graphics.printArea8 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 9:
                    if (Graphics.printArea9 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 10:
                    if (Graphics.printArea10 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 11:
                    if (Graphics.printArea11 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
                case 12:
                    if (Graphics.printArea12 == false)
                    {
                        " ".Position(g.PrevMapPositionj, g.PrevMapPositioni, "Red");
                        (g.Marker).Position(g.MapPositionj, g.MapPositioni, "Red");
                    }
                    break;
            }
        }
    }
    public void printItems()
    {
        foreach (Item item in Item.ItemList)
        {
            (item.Marker).Position(item.MapPositionj, item.MapPositioni, "Yellow");
            Graphics.PlaceCursorDefault();
        }
    }
    public void UpdateMap()
    {
        getAllPositions(); // getAllPositions, tar reda på positioner och ändrar värdet på mapLayout
        PrintCharacters();
        
        
        printInfoRightSide();
        CheckEventForHero();
        //PrintMap(); Ska inte printa map för då blinkar den hela tiden efter varje steg som Hero tar.
    
    }
}



