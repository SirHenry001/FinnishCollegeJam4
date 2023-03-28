using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript3 : MonoBehaviour
{
    public GameManager gameManager;
    public ItemHoldScript hold;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Object3")
        {
            print("OIKEINNNNN");
            hold.placeObj = true;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        hold.placeObj = false;
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
