using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int puzzleTaskCount = 0;
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


        Puzzle1();
        Puzzle2();
        
        if(puzzle1Compeleted == true && puzzle2Compeleted == true)
        {
            Destroy(prize.gameObject);
        }

    }

    public void Puzzle1()
    {
        //puzzle 1 success!
        if (puzzleTaskCount == 4)
        {
            light2.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void Puzzle2()
    {
        //puzzle 2 success!
        if (puzzleTaskCount == 4)
        {
            light2.GetComponent<Renderer>().material.color = Color.green;
            puzzle2Compeleted = true;
        }
    }
}
