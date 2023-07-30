using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public AudioSource lifeSound; // hang deklaráció

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World); // el kezd forogni a gömb az y tengely körül
    }
    void OnTriggerEnter(Collider other)
    {
        lifeSound.Play();
        Life.lifeValue += 1; // Plusz egy életünk lesz
        this.gameObject.SetActive(false); // a tárgy eltűnik
    }
}
