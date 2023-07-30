using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Több scene-t is felhasználunk ebben a scriptben

public class Health : MonoBehaviour
{
    public GameObject healthDisplay; // Életerő kijelző deklarációja
    public static int healthValue; // Életerő értékének deklarálása, statikus mert felhasználjuk másik scriptben is
    public int internalHealth; // Aktuális életerő deklarációja
    public GameObject hp100;
    public GameObject hp75;
    public GameObject hp50;
    public GameObject hp25;
    // Start is called before the first frame update
    void Start()
    {
        healthValue = 100; // Kezdeti érték 100%
    }

    // Update is called once per frame
    void Update()
    {
        if (healthValue >= 75)
        {
            hp100.SetActive(true);
            hp75.SetActive(false);
            hp50.SetActive(false);
            hp25.SetActive(false);
        }
        if (healthValue >= 50 && healthValue < 75)
        {
            hp100.SetActive(false);
            hp75.SetActive(true);
            hp50.SetActive(false);
            hp25.SetActive(false);
        }
        if (healthValue >= 25 && healthValue < 50)
        {
            hp100.SetActive(false);
            hp75.SetActive(false);
            hp50.SetActive(true);
            hp25.SetActive(false);
        }
        if (healthValue < 25)
        {
            hp100.SetActive(false);
            hp75.SetActive(false);
            hp50.SetActive(false);
            hp25.SetActive(true);
        }
        if (healthValue <= 0)
        {
            SceneManager.LoadScene(0); // Build and Settings alapján a Recycle scene kódja a 0-ás
        }
        internalHealth = healthValue; // A frissítéskor az aktuális életerő értékét veszi fel a healthValue
        healthDisplay.GetComponent<Text>().text = "" + healthValue + "%"; // kijelzőn az életerő értéke százalékban
    }
}
