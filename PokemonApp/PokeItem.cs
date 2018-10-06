using System;
using System.Collections.Generic;
using System.Text;

//Define your PokeItem model which will have a Name, and a Url.
namespace PokemonApp
{
    //Make your class public, since by default it is internal.
    public class PokeItem
    {
        //Define the constructor of your PokeItem which is the same name as class, and is not returning anything.
        //Will take a string name
        public PokeItem(string name)
        {
            Name = name;
        }
        //Your Properties are auto-implemented.
        public string Name { get; set; }
    }
}
