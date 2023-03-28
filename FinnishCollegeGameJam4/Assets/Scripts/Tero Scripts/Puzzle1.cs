using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public GameObject reward1;
    public GameObject object1;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "puzzle1")
        {
            print("Sait aseen osan");
            reward1.SetActive(true);
            object1.SetActive(false);



        }
    }
}