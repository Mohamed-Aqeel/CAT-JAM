using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    public GameObject Boss;

    private void OnCollisionEnter(Collision collision)
    {
        
        Instantiate(Boss, transform.position, Quaternion.identity);

    }
   
}
