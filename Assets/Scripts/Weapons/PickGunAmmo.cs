using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickGunAmmo : MonoBehaviour
{
    public GameObject fakeAmmoClip; // földön levő töltény deklarációja
    public AudioSource ammoPickupSound; // töltényfelvétel hangjának deklarálása

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false); // földön levő töltény eltűnik
        ammoPickupSound.Play(); // töltényfelvétel hangjának lejátszása
        Ammo.handgunAmmo += 10; // töltények száma 10-el növekszik
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
