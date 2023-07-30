using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldiers : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false; // Alapértelmezettként nem a karakterünkre néz a katona
    public GameObject theSoldier; // Katona "deklarációja"
    public AudioSource fireSound; // Lövéshang deklarációja
    public bool isFiring = false; // Alapértelmezettként nem tüzel
    public float fireRate = 1.0f;
    public int gHurt;
    public AudioSource[] hurtSound; // Tömböt deklarálunk a több sérüléshang miatt
    public GameObject hurtFlash; // hurtFlash deklarálása

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire()); // EnemyFire meghívása, amennyiben a karakterünk célpont
        }
        if (hitTag != "Player") // Ha nem célpont a player...
        {
            theSoldier.GetComponent<Animator>().Play("Idle"); // ellenkező esetben fegyvert elteszi
            lookingAtPlayer = false; // nem néz a karakterünkre
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true; // a feltételben false, így true-ra kell állítani
        theSoldier.GetComponent<Animator>().Play("FireGun", -1, 0);
        theSoldier.GetComponent<Animator>().Play("FireGun"); // Ha a karakterünk a célpont, akkor megtámadja, és tüzel
        fireSound.Play(); // lövéshang lejátszódik
        lookingAtPlayer = true; // ránéz a karakterünkre 
        Health.healthValue -= 5; // 5%-t sebez minden egyes lövésnél a karakterünk életerejéből.
        hurtFlash.SetActive(true); // aktiválódik a hurtFlash gameobject, azaz vérnyomok látszódnak a lövés után
        yield return new WaitForSeconds(0.2f);
        hurtFlash.SetActive(true); // inaktív lesz
        gHurt = Random.Range(0, 3);
        if (gHurt == 1)
        {
            hurtSound[gHurt].Play(); // A háromféle nyögés hangot random játsza le a kapott sebzések után
        }
        yield return new WaitForSeconds(fireRate); // várakozási idő a publikusan deklarált változó
        isFiring = false; // a ciklus végén ismét false-ra kell állítani a tüzelést
    }
}
