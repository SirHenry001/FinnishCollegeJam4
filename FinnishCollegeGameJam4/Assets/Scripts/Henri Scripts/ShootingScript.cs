using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;

    [SerializeField] private InputActionReference shoot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shoot.action.IsInProgress())
        {
            Instantiate(bullet, transform.position, transform.rotation);

        }


    }

    public void Shoot()
    {

    }
}
