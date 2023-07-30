using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // A "Text" osztály miatt kell ez a névtér

public class Ammo : MonoBehaviour
{
    public static int handgunAmmo; // töltények száma
    public GameObject ammoDisplay; // töltény kijelző
    // Start is called before the first frame update
    void Start()
    {
        handgunAmmo = 8;
    }

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + handgunAmmo; // kijelzőn a töltények száma, ami folyamatosan frissül
    }
}
