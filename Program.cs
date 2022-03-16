using System;
using Jogo_de_RPG.src.Entities;

namespace Jogo_de_RPG
{
     class Program
{
      static void Main(string[] args)
      {
             Knight arus = new Knight("Arus", 23, "knight");
             Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
             Ninja Ninja = new Ninja("Wedge", 29, "Ninja");
             Topapa Topapa = new Topapa("Topapa", 29, "Black Wizard");
            

             
               Console.WriteLine(arus.Attack());
               Console.WriteLine(Ninja.Attack());
               Console.WriteLine(Topapa.Black());
              
              
               
            }
     }
}








