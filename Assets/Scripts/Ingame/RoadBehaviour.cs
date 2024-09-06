using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RoadBehaviour : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float tpPos = 12.74f;

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.fixedDeltaTime;

        if (transform.position.y <= -tpPos)
        {
            transform.position = new Vector3(transform.position.x, tpPos, 10);
        }
    }
}
