using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Touch touch;
    private Vector2 touchPos;

    [SerializeField] private float moveSpeed = 2f;
    private Vector2 moveDir = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        }
        else
        {
            touchPos = transform.position;
        }

        if (touchPos.x > transform.position.x + 0.05f || Input.GetKey(KeyCode.D))
        {
            moveDir.x = moveSpeed;
        }
        else if (touchPos.x < transform.position.x - 0.05f || Input.GetKey(KeyCode.A))
        {
            moveDir.x = -moveSpeed;
        }
        else
        {
            moveDir.x = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDir * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("HighwayScene");
        }
    }
}
