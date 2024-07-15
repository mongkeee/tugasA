using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class CoinBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.fixedDeltaTime;

        if(transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
