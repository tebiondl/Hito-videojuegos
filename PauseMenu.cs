using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {


    public static bool paused = false;

    public GameObject pauseMenuUI;
    public Scene firstScene;
	// Use this for initialization
	void Start () {

        firstScene = SceneManager.GetActiveScene();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
		
	}

    public void Continue()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("First level");
        Time.timeScale = 1f;
        Score.scoreValue = 0;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
