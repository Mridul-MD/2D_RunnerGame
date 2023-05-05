using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    [SerializeField] int fdamage;
    private Transform playerobj;
    [SerializeField] float speed;
    private Vector2 target;
   

    private void Start()
    {

        playerobj = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(playerobj.position.x, playerobj.position.y);

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroyfireball();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "pumpkin_man")
        {
            //collision.gameObject.GetComponent<playerscript>().TakeDamagePlayer(fdamage);
            Destroyfireball();
        }

    }

    private void Destroyfireball()
    {
        Destroy(gameObject);
    }
}
