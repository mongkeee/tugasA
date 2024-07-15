using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] penghalangnya;
    [SerializeField] private GameObject[] notifnya;
    [SerializeField] private float waktuSpawn = 20f;
    private float hitungan = 0f;
    private float hitungMundur = 5f;
    private int rng = 0;

    // Update is called once per frame
    void Update()
    {
        if (hitungan > waktuSpawn)
        {
            notifnya[rng > 50 ? 1 : 0].SetActive(true);
            hitungMundur -= Time.deltaTime;
            if (hitungMundur < 0f)
            {
                GameObject mobilDipilih = penghalangnya[rng > 50 ? 1 : 0];
                Instantiate(mobilDipilih, new Vector2(rng > 50 ? 2.39375f : 0.47875f, transform.position.y), transform.rotation);
                hitungan = 0f;
                hitungMundur = 5f;
                waktuSpawn = Random.Range(15,30);
                notifnya[rng > 50 ? 1 : 0].SetActive(false);
            }
        }
        else
        {
            hitungan += Time.deltaTime;
            rng = Random.Range(0, 100);
        }
    }
}
