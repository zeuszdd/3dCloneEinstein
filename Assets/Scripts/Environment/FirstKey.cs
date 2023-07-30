using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKey : MonoBehaviour
{
    public GameObject keyUI; // kulcs deklarációja
    public GameObject lockedTrigger; // ajtó kinyitó trigger deklarálása
    public GameObject theKey;

    void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        theKey.SetActive(false);
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
