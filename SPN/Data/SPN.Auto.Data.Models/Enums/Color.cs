using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Data.Models.Enums
{
    public enum Color
    {
        //White
        White = 10,
        Snow = 20,
        Ivory = 30,
        Cream = 40,
        Porcelain = 50,

        //Yellow
        Yellow = 60,
        Bronze = 70,
        Beige = 80,
        Mustard = 90,
        Banana = 100,

        //Orange
        Orange = 150,
        Gold = 160,
        Pumpkin = 170,
        Amber = 180,

        //Red
        Red = 190,
        Maroon = 200,
        Ferrari = 210,
        Crimson = 220,
        Burgundy = 230,
        Mahogany = 240,

        //Pink
        Pink = 250,
        Magenta = 260,
        Fuchsia = 270,
        Flamingo = 280,
        Taffy = 290,

        //Violet
        Violet = 300,
        Orchid = 310,
        Grape = 320,
        Plum = 330,
        [Display(Name = "Royal Violet")]
        RoyalViolet = 340,
        Amethyst = 350,

        //Blue
        Blue = 360,
        [Display(Name = "Navy Blue")]
        NavyBlue = 370,
        Steel = 380,
        Azure = 390,
        Sky = 400,
        [Display(Name = "Baby Blue")]
        BabyBlue = 410,

        //Green
        Green = 420,
        [Display(Name = "Army Green")]
        Army = 430,
        Lime = 440,
        Emerald = 450,
        Pine = 460,

        //Brown
        Brown = 470,
        Mocha = 480,
        Wood = 490,
        Cinnamon = 500,
        Chocolate = 510,

        //Gray
        Gray = 520,
        Rhino = 530,
        Ash = 540,
        Charcoal = 550,
        Iron = 560

    }
}
