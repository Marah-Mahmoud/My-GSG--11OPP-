using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public string playerName01 = "";
        public int health01 = 0;
        public static int playerCount01 = 0;

        public void InitializePlayer01(string name01,int initialHealth01)
        {
            playerName01 = name01;
            health01 = initialHealth01;
            playerCount01++;
        }
        
        public void Heal01(int amount01)
        {
            health01 += amount01;
            Debug.Log(playerName01 + " health = " + health01);
        }

        public void Heal01(bool fullRestore01)
        {
            if (fullRestore01 == true)
            {
                health01 = 100;
            }
        }

        public static void ShowPlayerCount()
        {
            Debug.Log("Player count = " + playerCount01);
        }
        
    }

}
