using UnityEngine;

public class MonsterKill : MonoBehaviour
{
    private LayerMask bulletLayer;
    //private int hpMonster = 100 ;
    [SerializeField] private MonsterType monsterStats;
    public float hpMonster;
    private void Awake()
    {
        hpMonster = monsterStats.hpMonsterMax;
        bulletLayer = LayerMask.NameToLayer("bullet");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == bulletLayer)
        {
            hpMonster -= 50;
            if (hpMonster <= 0)
            {
                Destroy(transform.gameObject);
                MonsterManager.nbOfMonster -= 1;
                if (MonsterManager.nbOfKill < 29)
                {
                    MonsterManager.nbOfKill += 1;
                }
                else
                {
                    if (MonsterManager.nbOfKill <30)
                    {
                        MonsterManager.nbOfKill += 1;
                    }
                    EndCollider.canEnd = true;
                }
                
            }
        }
    }
}
