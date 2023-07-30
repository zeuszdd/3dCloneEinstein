using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secrets : MonoBehaviour
{
    public GameObject movableWall; // mozdítható fal deklarációja
    void OnTriggerEnter(Collider other)
    {
        movableWall.GetComponent<Animator>().enabled = true; // A mozdítható fal animációja beindul
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
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
