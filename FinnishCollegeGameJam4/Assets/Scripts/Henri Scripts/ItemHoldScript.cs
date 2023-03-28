using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ItemHoldScript : MonoBehaviour
{
    [Header("PickUp Setting")]
    [SerializeField] Transform holdArea;
    public GameObject heldObj;
    public Rigidbody heldObjRB;

    [Header("Physics")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;

    public bool placeObj;

    public GameObject placement1;
    public GameObject placement2;
    public GameObject placement3;

    [SerializeField] private InputActionReference leftClick, rightClick;

    public LayerMask layerMask;

    private void Update()
    {


            if(heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, pickupRange, layerMask))
                {
                    if(leftClick.action.IsPressed())
                    {
                        PickupObject(hit.transform.gameObject);
                        Debug.Log(pickupRange);
                        print("nostan esineen");
                    }

                }
            }

            if(heldObj != null)
            {
                MoveObject();

            }

        if(rightClick.action.IsPressed())
        {
            DropObject();
        }

        if (rightClick.action.IsPressed() && placeObj == true)
        {
            DropObject();
        }



    }

    void MoveObject()
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

    void PlaceObject()
    {
        heldObjRB.useGravity = true;
        heldObjRB.constraints = RigidbodyConstraints.None;
        heldObj.transform.position = placement1.transform.position;
        heldObjRB.transform.parent = null;
        heldObj = null;
        
    }
}
