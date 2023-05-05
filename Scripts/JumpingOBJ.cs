using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingOBJ : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    private Animator ani;
    private void Start()
    {
        
        ani = GetComponent<Animator>(); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.CompareTag("Player"))
        {
            ani.enabled= true;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.position.x, jumpPower * Time.deltaTime);
        }
    }

}
