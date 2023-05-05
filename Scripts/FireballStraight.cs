using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballStraight : MonoBehaviour
{
    [SerializeField] int fdamage;
    [SerializeField] float speed = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity= Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("fireBlocker"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }
}
