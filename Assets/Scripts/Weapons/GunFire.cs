using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject theGun; // Fegyver deklaráció
    public GameObject muzzleFlash; // villanás deklarálása
    public AudioSource gunFire; // lőfegyver hangjának deklarálása
    public AudioSource emptySound; // kiürült tár hangjának deklarálása
    public bool isFiring = false; // alapértelmezettként nem tüzel
    public float targetDistance; // célpont távolságának deklarálása
    public int damageAmount = 5; // sebzésünk nagysága (egész számként)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Ha kiürül a tár, akkor lejátsza a tárkiürítéses audiot
            if (Ammo.handgunAmmo < 1)
            {
                emptySound.Play();
            }
            else
            {
                // Ha van töltényünk, akkor a gomb lenyomásával a tüzelő ciklus beindul, már amennyiben nem tüzel.
                if (isFiring == false)
                {
                    StartCoroutine(FiringHandgun());
                }
            }
        }
    }

    IEnumerator FiringHandgun()
    {
        RaycastHit theShot;
        isFiring = true; // tüzel
        Ammo.handgunAmmo -= 1; // 1-el csökken a töltények száma
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        theGun.GetComponent<Animator>().Play("HandgunFire"); // Handgunfire animáció beindul
        muzzleFlash.SetActive(true); // flash megjelenik, aktiválódik az animációval
        gunFire.Play(); // fegyverhang lejátszódik
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false); // flash eltűnik
        yield return new WaitForSeconds(0.25f);
        theGun.GetComponent<Animator>().Play("New State"); // new state lejátszódik
        isFiring = false; // tüzelés leáll
    }
}
