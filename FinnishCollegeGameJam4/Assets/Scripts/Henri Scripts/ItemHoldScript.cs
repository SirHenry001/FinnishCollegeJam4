using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHoldScript : MonoBehaviour
{
    [Header("PickUp Setting")]
    [SerializeField] Transform holdArea;
    public GameObject heldObj;
    public Rigidbody heldObjRB;

    [Header("Physics")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;

    public StarterAssets.StarterAssetsInputs inputs;

    private void Update()
    {

        if (inputs.click)
        {
            if(heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, pickupRange))
                {
                    //pickup our object
                    PickupObject(hit.transform.gameObject);
                    Debug.Log(pickupRange);
                }
            }
            else
            {
                DropObject();
            }
            if(heldObj != null)
            {
                MoveObect();
            }
        }
    }

    void MoveObect()
    {
        if (Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - heldObj.transform.position);
            heldObjRB.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject(GameObject pickObj)
    {
        if(pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }

    void DropObject()
    {
            heldObjRB.useGravity = true;
            heldObjRB.drag = 1;
            heldObjRB.constraints = RigidbodyConstraints.None;

            heldObjRB.transform.parent = null;
            heldObj = null;

    }
}
