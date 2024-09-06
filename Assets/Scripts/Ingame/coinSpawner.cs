using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinnya;
    [SerializeField] private float waktuSpawn = 5f;
    private float hitungan = 0f;

    private void FixedUpdate()
    {
        hitungan += Time.deltaTime;
        if (hitungan > waktuSpawn)
        {
            Instantiate(coinnya, transform.position, transform.rotation);
            hitungan = 0f;
        }
    }
}
