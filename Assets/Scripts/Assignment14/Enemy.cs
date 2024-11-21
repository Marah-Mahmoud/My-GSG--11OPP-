using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14
{
    public class Enemy : Character
    {
        public Enemy(string name,int health) : base(name,health)
        {

        }

        public void Attack(Character target,int damage)
        {
            target.health -= damage;
            Debug.Log(name + " attacked  " + target.name + " for " + damage);
        }
 
    }

}

