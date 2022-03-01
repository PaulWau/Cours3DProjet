 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class MonsterMove : MonoBehaviour
 {
 
     [SerializeField] private Transform Player;
     int MoveSpeed = 4;
     int MaxDist = 1000;
     int MinDist = 5;

 
     void Update()
     {
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             if (Vector3.Distance(transform.position, Player.position) < MaxDist)
             {
                 //Le gars prend des dégats
             }
 
         }
     }
 }