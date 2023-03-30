using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour
{
    [SerializeField] private InputActionReference retry,mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(retry.action.IsPressed())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (mainmenu.action.IsPressed())
        {
            SceneManager.LoadScene(0);
        }
    }
}
