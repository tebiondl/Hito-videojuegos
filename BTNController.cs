using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTNController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene("First level");
        Time.timeScale = 1f;
        Score.scoreValue = 0;

    }

    public void Quit()
    {
        Application.Quit();

    }
}
