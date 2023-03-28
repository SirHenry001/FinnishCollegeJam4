using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float startDelay = 2.0f;
    public GameObject enemy;
    private float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        targetTime = 5;

    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0)
        {
            SpawnEnemy();
            targetTime = Random.Range(3, 6);
        }
        void SpawnEnemy()
        {


            Instantiate(enemy, transform.position, transform.rotation);

        }
    }
}