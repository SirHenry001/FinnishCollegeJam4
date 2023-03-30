using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level2Script : MonoBehaviour
{
    
    public float startTimer;
    public float surviveTimer;
    public Image bgImage;
    public Image crosshair;
    public TextMeshProUGUI startCounterText;
    public TextMeshProUGUI surviveText;
    public TextMeshProUGUI surviveCounterText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI winText;

    public GameObject enemySpawner;
    public GameObject[] enemiesInScene;

    private void Awake()
    {
        startTimer = 5;
        surviveTimer = 30f;
        gameOverText.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

        surviveCounterText.gameObject.SetActive(false);
        surviveText.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(false);
        surviveCounterText.GetComponent<TextMeshProUGUI>().text = surviveTimer.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        startCounterText.GetComponent<TextMeshProUGUI>().text = startTimer.ToString("F0");

        startTimer -= Time.deltaTime;
        if(startTimer <= 0)
        {
            StartTimer();
            startCounterText.gameObject.SetActive(false);
            bgImage.gameObject.SetActive(false);
            crosshair.gameObject.SetActive(true);
            
        }

    }

    public void StartTimer()
    {
        surviveCounterText.gameObject.SetActive(true);
        surviveText.gameObject.SetActive(true);
        surviveTimer -= Time.deltaTime;
        surviveCounterText.GetComponent<TextMeshProUGUI>().text = surviveTimer.ToString("F2");

        if(surviveTimer <= 0)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        surviveTimer = 0;
        surviveCounterText.gameObject.SetActive(false);
        surviveText.gameObject.SetActive(false);
        winText.gameObject.SetActive(true);
        crosshair.gameObject.SetActive(false);
        KillEnemies();
    }

    public void KillEnemies()
    {
        Destroy(enemySpawner);
        enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");

        for(int i = 0; i < enemiesInScene.Length; i++)
        {
            Destroy(enemiesInScene[i]);
        }

    }
}
