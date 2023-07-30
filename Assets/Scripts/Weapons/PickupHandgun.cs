using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandgun : MonoBehaviour
{
    public GameObject realHandgun; // kézben levő fegyver
    public GameObject fakeHandgun; // földön fekvő fegyver
    public AudioSource handgunPickupSound; // fegyver felvételének a hangja
    public GameObject pistolImage; // A panelen levő pisztoly kép deklarálása

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true); // kézben levő fegyver megjelenik
        fakeHandgun.SetActive(false); // földön fekvő fegyver eltűnik
        handgunPickupSound.Play(); // fegyver felvételének hangja lejátszódik
        GetComponent<BoxCollider>().enabled = false; // BoxCollider eltűnik
        pistolImage.SetActive(true); // a fegyver felvételekor megjelenik a panelen a pisztoly kép
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
