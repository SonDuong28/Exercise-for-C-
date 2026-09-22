using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1
{
    public class Player
    {
       public string Name;
       public int Level;
       public int HP;
       
        public Player(string name)
        {
            Name = name;
            Level = 1;
            HP = 100;
        }
        public void DetailPlayer()
        {
            Console.WriteLine($"Player: {Name}, Level: {Level}, HP: {HP}");
        }
    }
}
