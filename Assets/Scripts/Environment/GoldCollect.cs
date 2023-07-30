using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollect : MonoBehaviour
{
    // Hasonló az eljárás, mint a fegyverfelvételnél (pickuphandgun.cs), a játékba még nincsen bekötve az aranyrúd
    public GameObject goldIngots; // aranyrúd deklarációja
    public AudioSource collectSound; // arany begyűjtésének hangja
    
    void OnTriggerEnter(Collider other)
    {
        Score.scoreValue += 500; // 500 pont egy arany
        goldIngots.SetActive(false); // aranyrúd eltűnik
        collectSound.Play(); // aranyfelvét hangja lejátszódik
        GetComponent<BoxCollider>().enabled = false; // az arany eltűnik a felvételkor
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
