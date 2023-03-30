using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSucces2 : MonoBehaviour
{
    public BookPuzzle bookPuzzle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bookcollision")
        {
            bookPuzzle.book2Out = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "bookcollision")
        {
            bookPuzzle.book2Out = true;
        }
    }

    private void Start()
    {
        bookPuzzle = GameObject.Find("PUZZLE1OBECTS").GetComponent<BookPuzzle>();
    }
}
