using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{

    public GameObject controlText;
    public GameObject backButton;
    public GameObject startButton;
    public GameObject controlButton;
    public GameObject quitButton;
    public GameObject jamText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ControlsOn()
    {
        controlText.SetActive(true);
        jamText.SetActive(false);
        backButton.SetActive(true);
        startButton.SetActive(false);
        controlButton.SetActive(false);
        quitButton.SetActive(false);

    }

    public void ControlsOff()
    {
        controlText.SetActive(false);
        backButton.SetActive(false);
        jamText.SetActive(true);
        startButton.SetActive(true);
        controlButton.SetActive(true);
        quitButton.SetActive(true);

    }

    public void Exit()
    {
        Application.Quit();
    }
}
