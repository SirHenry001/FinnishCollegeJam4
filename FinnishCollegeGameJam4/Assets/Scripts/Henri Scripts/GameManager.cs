using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public bool puzzle1Compeleted;
    public bool puzzle2Compeleted;

    public GameObject light1;
    public GameObject light2;

    public GameObject prize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(puzzle1Compeleted == true && puzzle2Compeleted == true)
        {
            Destroy(prize.gameObject);
        }

    }

    public void Puzzle1()
    {
        light1.GetComponent<Renderer>().material.color = Color.green;
        puzzle1Compeleted = true;
    }

    public void Puzzle2()
    {

            light2.GetComponent<Renderer>().material.color = Color.green;
            puzzle2Compeleted = true;

    }
}
