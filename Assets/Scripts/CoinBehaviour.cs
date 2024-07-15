using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float lane = 0;

    private void Start()
    {
        lane = Random.Range(0, 4);
        transform.position = new Vector3(lane * 0.9575f, transform.position.y, 0);
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.fixedDeltaTime;

        if(transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }


}
