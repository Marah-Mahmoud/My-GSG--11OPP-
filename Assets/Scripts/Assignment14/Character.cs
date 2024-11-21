using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14
{
    public class Character
    {
        public string name
        {
            get;
            set;
        }
        
        public int health;

        public int Health 
        {
            get { return health; }
            set 
            { 
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }

        public Character(string name,int health)
        {
            this.name = name;
            this.health = health;
        }

    }
 
}
