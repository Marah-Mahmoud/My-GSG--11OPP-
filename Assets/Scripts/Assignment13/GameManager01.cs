using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player01 = new Player();
        Player player02 = new Player();

        player01.InitializePlayer("Jeniver",100);
        player02.InitializePlayer("Omar",80);

        Debug.Log("Player name is: " + player01.playerName + "  ,and her health is " + player01.health);
        Debug.Log("Player name is: " + player02.playerName + "  ,and his health is " + player02.health);

        player02.Heal(10);
        player02.Heal(true);
        Debug.Log(player02.playerName + " health is " + player02.health);

        Player.ShowPlayerCount();
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
