using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.fixedDeltaTime;

        if (transform.position.y < -20f)
        {
            Destroy(gameObject);
        }
    }
}
