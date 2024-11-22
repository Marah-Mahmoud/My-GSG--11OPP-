using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass14
{

    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player player = new Player("Zarifeh",80);
            Enemy enemy = new Enemy("Subhi",50);

            Debug.Log("Player: " + player.name + ",and her health = " + player.health);
            Debug.Log("Enemy: " + enemy.name + ",and his health = " + enemy.health);

            player.Heal(20);
            //Debug.Log(player.name + ",and her health = " + player.health);
            
            enemy.Attack(player,30);
            Debug.Log("So " + player.name + " health's now = " + player.health);
        }

    }
}
