// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// namespace Assignment16
// {
//     public class Character1
//     {
//         public string name;
//         private int health;
//         protected Position position;

//         public int Health 
//         {
//             get { return health; }
//             set { if (value > 100) health = 100;
//                 else if (value < 0) health = 0;
//                 else health = value;
//                 }
//         }

//         public void parameterized(string name,int health,Position position)
//         {
//             name = name;
//             health = health;
//             this.position = position;

//         }

//         public Character1() : this("No name", 100, new Position(0,0,0))
//         {

//         }

//         public virtual void DisplayInfo()
//         {
//             Debug.Log(name,health);
//             Position.PrintPosition();
//         }

//         public void Attack(int damage,Character target)
//         {

//         }

//         public void Attack(int damage,Character target,string attackType)
//         {

//         }






//     }
// }