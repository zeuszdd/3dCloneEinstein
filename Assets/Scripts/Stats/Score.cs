using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreDisplay; // kijelző deklarálása
    public static int scoreValue = 0; // kezdőérték 0
    public int internalScore; // részpontszám deklarációja
    public GameObject finalScore; // szint végi pontszám deklarációja

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue; // aktuális pontszám frissül
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue; // panelra kiírja
        finalScore.GetComponent<Text>().text = "" + scoreValue; // végső pontszám kiiratása
    }
}
