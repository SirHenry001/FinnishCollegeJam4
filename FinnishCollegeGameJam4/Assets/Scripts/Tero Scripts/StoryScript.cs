using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StoryScript : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HitStop());
    }

    public IEnumerator HitStop()
    {
        yield return new WaitForSecondsRealtime(1f);
        Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        Text4.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(2);

    }

}