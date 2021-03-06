using System.Collections;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    public int maxSpawn = 30;
    private bool canSpawn = true;
    [SerializeField] private Transform monsterHolder;
    void Update()
    {
        if (canSpawn)
        {
            if (MonsterManager.nbOfMonster < maxSpawn)
            {
                Instantiate(monster, transform.position + transform.right * 0.8f, Quaternion.identity, monsterHolder);
                MonsterManager.nbOfMonster += 1;
                Debug.Log(MonsterManager.nbOfMonster);
                StartCoroutine(MonsterCanSpawn());
            }

        }

    }
    private IEnumerator MonsterCanSpawn()
    {
        canSpawn = false;
        yield return new WaitForSeconds(2f);
        canSpawn = true;
    }
}
