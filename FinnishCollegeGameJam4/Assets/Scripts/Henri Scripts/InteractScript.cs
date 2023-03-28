using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public bool canInteract = false;
    public GameObject hintText;
    public LayerMask layerMask;
    public float rayCastLenght = 5f;

    public StarterAssets.StarterAssetsInputs inputs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayCastLenght, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            canInteract = true;
            hintText.SetActive(true);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayCastLenght, Color.red);
            canInteract = false;
            hintText.SetActive(false);
            Debug.Log("Did not Hit");
        }
    }
}
