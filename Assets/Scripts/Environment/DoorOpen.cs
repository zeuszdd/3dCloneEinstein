using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject theDoor; // Az "ajtó" deklarálása
    public AudioSource doorMoving; // Az ajtó mozgásának hangja
    // Az ajtó kinyílásának mozgása az Animátor alkalmazásával.
    void OnTriggerEnter(Collider other)
    {
        doorMoving.Play(); // Ajtó mozgásának lejátszása
        theDoor.GetComponent<Animator>().Play("DoorOpen"); // Ajtónyitás
        this.GetComponent<BoxCollider>().enabled = false; // BoxCollider kikapcsol
        StartCoroutine(DoorClose()); // Ajtózárás metódus meghívása
    }

    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(5);
        doorMoving.Play(); // Ajtó mozgásának lejátszása
        theDoor.GetComponent<Animator>().Play("DoorClose"); // Ajtó záródása
        this.GetComponent<BoxCollider>().enabled = true; // BoxCollider bekapcsol
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
