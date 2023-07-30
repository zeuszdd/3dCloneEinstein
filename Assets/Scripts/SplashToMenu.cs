using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2); // Visszatérünk a főmenübe
    }
}
