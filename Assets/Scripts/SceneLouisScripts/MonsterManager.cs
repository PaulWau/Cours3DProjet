 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class MonsterManager : MonoBehaviour
 {
     
     int MoveSpeed = 4;
     int MaxDist = 1000;
     int MinDist = 5;
     private bool canDoDamage = true;

 
     void Update()
     {
         transform.LookAt(GameManager.player.transform.position);

         if (Vector3.Distance(transform.position, GameManager.player.transform.position) >= MinDist)
         {

             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
         }

         if (Vector3.Distance(transform.position, GameManager.player.transform.position) <= MinDist+0.1f)
         {
             if (canDoDamage)
             {
                 GameManager.TakeDamage(10);
                 Debug.Log(GameManager.playerLife);
                 StartCoroutine(TakeDamageRate());
             }
             
         }
 
         
     }

     private IEnumerator TakeDamageRate()
     {
         canDoDamage = false;
         yield return new WaitForSeconds(1f);
         canDoDamage = true;
     }
 }