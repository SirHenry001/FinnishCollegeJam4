using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public GameManager gameManager;
    public ItemHoldScript hold;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Object1")
        {
            hold.placeObj1 = true;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "Object1")
        {
            hold.placeObj1 = false;

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
