using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PuzzleScript2 : MonoBehaviour
{

    public GameManager gameManager;
    public ItemHoldScript hold;



    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Object2")
        {
            print("OIKEINNNNN");
            hold.placeObj2 = true;
        }

    }
    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "Object2")
        {
            hold.placeObj2 = false;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
