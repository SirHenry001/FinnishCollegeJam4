using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootMenu : MonoBehaviour
{

    public GameObject gameoverText;

    [SerializeField] private InputActionReference retryLevel, mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(action)
    }

    public void GameOver()
    {
        gameoverText.SetActive(true);
    }
}
