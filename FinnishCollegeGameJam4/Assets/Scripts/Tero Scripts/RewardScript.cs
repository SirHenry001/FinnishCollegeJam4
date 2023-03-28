using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardScript : MonoBehaviour
{
    public GameObject reward1;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "PlayerCapsule")
        {
            print("keräsit aseen osan");

            reward1.SetActive(false);
        }
    }
}