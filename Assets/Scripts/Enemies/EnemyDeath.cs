using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20; // Ellenség hp-ja
    public bool enemyDead = false; // Él
    public GameObject enemyAI;
    public GameObject theEnemy;
    void DamageEnemy (int damageAmount)
    {
        enemyHealth -= damageAmount; // Ellenség módosított hp-ja, levonva a mi sebzésünket
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false) // ha lecsökken 0-ra, vagy alá az életereje, és él
        {
            enemyDead = true; // Ellenség meghal
            // theEnemy.GetComponent<Animator>().Play("Death"); -> animáció hiánya miatt kikommentelve
            enemyAI.SetActive(false);
            Destroy(theEnemy); // Az ellenfél elpusztulása után eltűnik a teste a képernyőről.
            Score.scoreValue += 100; // 100 pontot kapunk az ellenfél megölése után
            LevelStat.enemyCount += 1; // hozzáadja a szint végén kiírt leölt ellenség darabszámához
        }
    }
}
