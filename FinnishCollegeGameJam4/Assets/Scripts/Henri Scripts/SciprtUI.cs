using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciprtUI : MonoBehaviour
{
    public GameObject bodyText;
    public GameObject hintText1;
    public GameObject hintText2;

    public GameObject interactText;
    public GameObject interactText2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InteractTextOn()
    { interactText.SetActive(true); }
    public void InteractTextOff()
    { interactText.SetActive(false); }

    public void BodyTextOn()
    { interactText2.SetActive(true); }
    public void BodyTextOff()
    { interactText2.SetActive(false); }

    public void bodyTextOn()
    { bodyText.SetActive(true); }
    public void bodyTextoff()
    { bodyText.SetActive(false); }

    public void hintText1On()
    { hintText1.SetActive(true); }
    public void hintText1off()
    { hintText1.SetActive(false); }

    public void hintText2On()
    { hintText2.SetActive(true); }
    public void hintText2off()
    { hintText2.SetActive(false); }
}
