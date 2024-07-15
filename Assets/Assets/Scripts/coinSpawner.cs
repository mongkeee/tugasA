using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinnya;
    [SerializeField] private float waktuSpawn = 5f;
    private float hitungan = 0f;

    // Update is called once per frame
    void Update()
    {
        hitungan += Time.deltaTime;
        if (hitungan > waktuSpawn)
        {
            int rng = Random.Range(-1, 1);
            Instantiate(coinnya, new Vector3(rng >= 0 ? -0.48f : -1.435f, 7, 0), transform.rotation);
            hitungan = 0f;
        }
    }
}
