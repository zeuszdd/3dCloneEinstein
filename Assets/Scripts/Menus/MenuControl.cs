using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene-k váltása miatt van szükség rá

public class MenuControl : MonoBehaviour
{
    public AudioSource clickSound; // Kattintó hang deklarálása
    public GameObject fadeOut;
    public int loadScene;
    public int loadLives;
    public int loadScore;
    public int loadAmmo;

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine()); // Új játék választásánál beindul a ciklus
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play(); // Klikkelő hang lejátszódik
        fadeOut.SetActive(true); // Fade out bekapcsol
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1); // Betölti a fő scene-t (1-es kód)
    }

    public void QuitGame()
    {
        Application.Quit(); // A játékból való kilépés esetén kilép az applikációból.
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad");
        if (loadScene == 4)
        {
            // nem történik semmi
        }
        else
        {
            StartCoroutine(LoadGameRoutine()); // Játék betöltése
        }
    }

    IEnumerator LoadGameRoutine()
    {
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadLives = PlayerPrefs.GetInt("LivesSaved");
        loadAmmo = PlayerPrefs.GetInt("AmmoSaved");
        clickSound.Play(); // Klikkelő hang lejátszódik
        fadeOut.SetActive(true); // Fade out bekapcsol
        yield return new WaitForSeconds(2);
        //LevelStat.nextFloor = loadScene;
        LevelStat.nextFloor = 4;
        Life.lifeValue = loadLives;
        Score.scoreValue = loadScore;
        Ammo.handgunAmmo = loadAmmo;
        SceneManager.LoadScene(1); // Betölti a fő scene-t (1-es kód), több szint esetén: SceneManager.LoadScene(loadScene)
    }

    public void CreditButton()
    {
        SceneManager.LoadScene(3); // CreditMenu betöltése
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