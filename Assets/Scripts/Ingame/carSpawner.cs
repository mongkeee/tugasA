using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] mobilnya;
    [SerializeField] private float waktuSpawn = 5f;
    private float hitungan = 0f;

    // Update is called once per frame
    void Update()
    {
        hitungan += Time.deltaTime;
        if (hitungan > waktuSpawn)
        {
            int rng = Random.Range(1, 10);

            GameObject mobilDipilih = rng >= 7 ? mobilnya[1] : mobilnya[0];
            Instantiate(mobilDipilih, transform.position, transform.rotation);
            hitungan = 0f;
        }
    }
}
