using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public GameObject lifeDisplay; // Kijelző deklarációja
    public static int lifeValue; // Alapértelmezett, hogy 3 életünk van
    public int internalLife; // Aktuális életszámunk
    // Start is called before the first frame update
    void Start()
    {
        lifeValue = 3;
    }

    // Update is called once per frame
    void Update()
    {
        internalLife = lifeValue; // Az életszám értéke az aktuálissal fog megegyezni a frissüléskor
        lifeDisplay.GetComponent<Text>().text = "" + lifeValue; // Az értéket a kijelzőpanelen jeleníti meg.
    }
}
