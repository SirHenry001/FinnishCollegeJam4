using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{

    public GameObject controlText;
    public GameObject BackButton;
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

    }

    public void ControlsOff()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
