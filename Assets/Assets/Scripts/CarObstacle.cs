using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.fixedDeltaTime;

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
