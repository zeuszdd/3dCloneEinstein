using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStat : MonoBehaviour
{
    public static int enemyCount; // leölt ellenségek számának deklarációja
    public GameObject enemyDisplay; // ennek kijelzőjének a deklarálása
    public static int nextFloor = 4; // értéke a szint scene-jének sorszáma lesz (file/build and settings, lvl2=5, lvl3=6, stb.), így 4 lesz az alapérték
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyDisplay.GetComponent<Text>().text = "" + enemyCount; // a kijelző panelre kiiratjuk a leölt ellenségek darabszámát
    }
}
