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

    public SciprtUI ui;

    //public StarterAssets.StarterAssetsInputs inputs;
    [SerializeField] private InputActionReference interact;
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
            StartCoroutine("HintOnButtonPress");
        }

        if (interact.action.IsPressed() && canInteract2)
        {
            StartCoroutine("HintOn2ButtonPress");
        }

        if (interact.action.IsPressed() && canInteract3)
        {
            StartCoroutine("HintOn3ButtonPress");
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
            InteractInfo();
            canInteract3 = true;
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2.5f, Color.red);
            InteractInfo();
            canInteract3 = false;
        }
    }



    public void InteractInfo()
    {
        if(canInteract1 == true || canInteract2 ==true || canInteract3 ==true)
        {ui.InteractTextOn();}
        else
        {ui.InteractTextOff();}
    }
    public IEnumerator HintOnButtonPress()
    {
        ui.hintText1On();
        yield return new WaitForSeconds(2f);
        ui.hintText1off();
    }

    public IEnumerator HintOn2ButtonPress()
    {
        ui.hintText2On();
        yield return new WaitForSeconds(2f);
        ui.hintText2off();
    }

    public IEnumerator HintOn3ButtonPress()
    {
        ui.bodyTextOn();
        yield return new WaitForSeconds(2f);
        ui.bodyTextoff();
    }


}
