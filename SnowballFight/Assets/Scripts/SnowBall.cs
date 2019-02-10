using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D theRB;
    public GameObject snowBallEffect;
    

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * transform.localScale.x, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player1")
        {
            FindObjectOfType<GameManager>().HurtP1();
        } else if (collision.tag == "Player2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }
        Instantiate(snowBallEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
