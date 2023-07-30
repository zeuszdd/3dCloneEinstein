using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene cserék miatt ismét szükség lesz erre a névtérre

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOver; // Gameover deklarálása
    // Start is called before the first frame update
    void Start()
    {
        Life.lifeValue -= 1; // Halál esetén csökken 1-el az életszámunk
        if (Life.lifeValue == 0)
        {
            gameOver.SetActive(true); // Amennyiben az összes életünk elfogy, a gameover ablak aktívvá válik.
        }
        else
        {
            SceneManager.LoadScene(1); // Ha még marad életünk, akkor az 1-es scene, azaz a fő scene marad
            /*
            if (LevelStat.nextFloor == 4)
            {
                SceneManager.LoadScene(1); // Ha még marad életünk, akkor az 1-es scene, azaz a fő scene marad
            }
            else
            {
                SceneManager.LoadScene(LevelStat.nextFloor); // minden más esetben az aktuális szint elejére tér vissza, de jelenleg 1 szint van.
            }
            */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
