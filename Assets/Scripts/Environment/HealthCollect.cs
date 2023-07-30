using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollect : MonoBehaviour
{
    public AudioSource collectSound; // Hang deklaráció
    void OnTriggerEnter(Collider other)
    {
        if (Health.healthValue < 81)
        {
            Health.healthValue += 20; // 81% alatt 20-t javul az életerőnk az elsősegény felvételekor
        }
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false; // Az adott tárgy eltűnik
        this.gameObject.SetActive(false);
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
