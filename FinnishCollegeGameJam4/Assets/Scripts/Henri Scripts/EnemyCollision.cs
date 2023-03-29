using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    public ShootMenu shootMenu;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            shootMenu.GameOver();
            
        }
    }

    private void Start()
    {
        shootMenu = GameObject.Find("GAMEOVERCANVAS").GetComponent<ShootMenu>();
    }
}
