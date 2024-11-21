using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14
{
    public class Player : Character 
    {
        public Player(string name,int health) : base(name,health)
        {

        }
 
        public void Heal(int amount)
        {
            health += amount;
            //Debug.Log(name + " health = " + health);
            Debug.Log(name + " healed by " + amount + ". So her current health = " + health);
        }
    }


}
