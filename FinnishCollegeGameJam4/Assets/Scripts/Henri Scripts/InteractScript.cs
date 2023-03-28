using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractScript : MonoBehaviour
{
    public bool canInteract1 = false;
    public bool canInteract2 = false;
    public bool canInteract3 = false;
    public LayerMask layerMask;
    public float rayCastLenght = 5f;

    public GameObject Puzzle1InfoBox;
    public GameObject Puzzle2InfoBox;

    public SciprtUI ui;
    public GameManager gameManager;
    public ItemHoldScript hold;

    //public StarterAssets.StarterAssetsInputs inputs;
    [SerializeField] private InputActionReference interact,submit,skip;
    //public InputAction controls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastCheck1();
        RaycastCheck2();
        RaycastCheck3();

        if (interact.action.IsPressed() && canInteract1)
        {
            HintOnButtonPress();
        }

        if (interact.action.IsPressed() && canInteract2)
        {
            HintOn2ButtonPress();
        }

        if (interact.action.IsPressed() && canInteract3)
        {
            HintOn3ButtonPress();
        }

        if (submit.action.IsPressed())
        {
            ui.hintText1off();
            ui.hintText2off();
            ui.bodyTextoff();
            Time.timeScale = 1f;
        }

        


        if (submit.action.IsPressed() && hold.placeObj1 == true && hold.placeObj2 == true)
        {
            ui.hintText2off();
            Time.timeScale = 1f;
            gameManager.Puzzle2();
            Puzzle2InfoBox.GetComponent<Collider>().enabled = false;
        }


    }

    public void RaycastCheck1()
    {
        RaycastHit hit;

        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayCastLenght, layerMask)) && (hit.transform.gameObject.tag == "puzzle1"))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            InteractInfo();
            canInteract1 = true;
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayCastLenght, Color.red);
            InteractInfo();
            canInteract1 = false;
        }
    }

    public void RaycastCheck2()
    {
        RaycastHit hit;

        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayCastLenght, layerMask)) && (hit.transform.gameObject.tag == "puzzle2"))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            InteractInfo();
            canInteract2 = true;
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayCastLenght, Color.red);
            InteractInfo();
            canInteract2 = false;
        }
    }

    public void RaycastCheck3()
    {
        RaycastHit hit;

        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.5f, layerMask)) && (hit.transform.gameObject.tag == "puzzle3"))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            InteractInfo2();
            canInteract3 = true;
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2.5f, Color.red);
            InteractInfo2();
            canInteract3 = false;
        }
    }



    public void InteractInfo()
    {
        if(canInteract1 == true || canInteract2 ==true)
        {ui.InteractTextOn();}
        else
        {ui.InteractTextOff();}
    }

    public void InteractInfo2()
    {
        if (canInteract3 == true)
        { ui.BodyTextOn(); }
        else
        { ui.BodyTextOff(); }
    }
    public void HintOnButtonPress()
    {
        ui.hintText1On();
        Time.timeScale = 0f;
    }

    public void HintOn2ButtonPress()
    {
        ui.hintText2On();
        Time.timeScale = 0f;
    }

    public void HintOn3ButtonPress()
    {
        ui.bodyTextOn();
        Time.timeScale = 0f;
    }


}
