 using System.Collections;
 using UnityEngine;
 public class MonsterManager : MonoBehaviour
 {
     int MinDist = 5;
     private bool canDoDamage = true;
     public static int nbOfMonster = 0;
     public static int nbOfKill = 0;
     [SerializeField] private MonsterType monsterStats;

 
     void Update()
     {
         transform.LookAt(GameManager.player.transform.position);

         if (Vector3.Distance(transform.position, GameManager.player.transform.position) >= MinDist)
         {

             transform.position += transform.forward * monsterStats.speed * Time.deltaTime;
         }

         if (Vector3.Distance(transform.position, GameManager.player.transform.position) <= MinDist+0.1f)
         {
             if (canDoDamage)
             {
                 GameManager.TakeDamage(monsterStats.damageOnPlayer);
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