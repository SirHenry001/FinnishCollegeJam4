using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private InputActionReference pause;
    [SerializeField] private InputActionReference resume;
    [SerializeField] private InputActionReference mainmenu;
    [SerializeField] private InputActionReference retry;

    public GameObject resumebutton;
    public GameObject mainmenubutton;
    public GameObject retrybutton;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pause.action.IsPressed())
        {

            print("Pause");
        
        }
        
        if (resume.action.IsPressed())
        {

            print("Resume");
        }

        if (mainmenu.action.IsPressed())
        {

            print("mainmenu");
        }

        if (retry.action.IsPressed())
        {

            print("Retry");
        }
    }
}
