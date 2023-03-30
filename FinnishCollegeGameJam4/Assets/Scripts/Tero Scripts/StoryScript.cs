using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StoryScript : MonoBehaviour
{
   

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        StartCoroutine(HitStop());
    }

    public IEnumerator HitStop()
    {
        yield return new WaitForSecondsRealtime(1f);
        Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(4f);
        Text4.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Text5.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene(2);

    }

}