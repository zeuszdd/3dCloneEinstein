using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;
    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false); // leáll a timer a szint végén
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false; //Karakterünk eltűnik a szintről, emellett kell a namespace is
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true); // főscene eltűnik a szint végén
        PlayerPrefs.SetInt("SceneToLoad", LevelStat.nextFloor);
        PlayerPrefs.SetInt("ScoreSaved", Score.scoreValue);
        PlayerPrefs.SetInt("LivesSaved", Life.lifeValue);
        PlayerPrefs.SetInt("AmmoSaved", Ammo.handgunAmmo);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true); // szint végén megjelenik az összesítő panel
        //yield return new WaitForSeconds(10);
        //Score.scoreValue = 0; // resetelődni fognak a statok a szintlépéskor
        //LevelStat.enemyCount = 0;
        //LevelStat.nextFloor += 1; // hozzáad 1-et a szint teljesítésekor, kikommentelve, demoverzióban csak 1 szint lesz
        //SceneManager.LoadScene(LevelStat.nextFloor); // Lvl 2-es szint betöltése. Kikommentelve a demoverzió miatt.
        SceneManager.LoadScene(3);
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
