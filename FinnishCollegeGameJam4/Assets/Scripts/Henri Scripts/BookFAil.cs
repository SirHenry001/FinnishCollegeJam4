using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookFAil : MonoBehaviour
{
    public BookPuzzle bookPuzzle;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "collisionfail")
        {
            bookPuzzle.failCount -= 1;
        }
    }

    private void Start()
    {
        bookPuzzle = GameObject.Find("PUZZLE1OBECTS").GetComponent<BookPuzzle>();
    }
}
