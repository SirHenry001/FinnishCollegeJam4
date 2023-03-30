using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    public ShootMenu shootMenu;
    public Level2Script level2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            shootMenu.GameOver();
            level2.gameOverText.gameObject.SetActive(true);
            
        }
    }

    private void Start()
    {
        shootMenu = GameObject.Find("GAMEOVERCANVAS").GetComponent<ShootMenu>();
        level2 = GameObject.Find("Level2Manager").GetComponent<Level2Script>();
    }
}
