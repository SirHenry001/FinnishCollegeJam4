using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int puzzleTaskCount = 0;
    public bool puzzle2Compeleted;

    public GameObject light1;
    public GameObject light2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //puzzle 1 success!
        if (puzzleTaskCount == 4)
        {
            light2.GetComponent<Renderer>().material.color = Color.green;
        }

        //puzzle 2 success!
        if (puzzleTaskCount == 4)
        {
            light2.GetComponent<Renderer>().material.color = Color.green;
        }
        
    }
}
