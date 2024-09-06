using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float lane = 0;

    [SerializeField] private bool changeLane = false;
    private float moveDir = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 3f);
        lane = Random.Range(0, 4);
        transform.position = new Vector2(lane * 0.9575f, transform.position.y);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!changeLane)
        {
            RayCastMobilDepan();
        }
        else
        {
            if(transform.position.x >= lane * 0.9575f - 0.05 && lane * 0.9575f + 0.05 >= transform.position.x)
            {
                moveDir = 0;
                changeLane = false;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(moveDir, -speed) * Time.fixedDeltaTime);
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    public void RayCastMobilDepan()
    {
        float colSizeY = this.GetComponent<BoxCollider2D>().size.y;
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + colSizeY / 2 + 0.1f), Vector2.up, 3);
        if (hit.collider != null)
        {
            if(hit.collider.tag == "Obstacle")
            {
                changeLane = true;
                switch (lane)
                {
                    case 0:
                        lane = 1;
                        moveDir = 1.5f;
                        break;
                    case 1:
                        lane = 2;
                        moveDir = 1.5f;
                        break;
                    case 2:
                        lane = 1;
                        moveDir = -1.5f;
                        break;
                    case 3:
                        lane = 2;
                        moveDir = -1.5f;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
