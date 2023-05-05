using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerscriptSC : MonoBehaviour
{
    private float coinPoints = 0;
    private float diamondPoints = 0;
    private Rigidbody2D rb;
    private float tt;
    //[SerializeField] float speed;
    [SerializeField] float jumppower;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    private Animator ani;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani= GetComponent<Animator>();
    }

    void Update()
    {
        tt += Time.deltaTime;
       
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapBox(groundCheck.position, groundCheck.localScale, 0,ground);
    }
    public void Jump(InputAction.CallbackContext context)
    {
       
        if (context.started && IsGrounded())
        {
           
            rb.velocity = new Vector2(rb.velocity.x, jumppower );
            ani.SetBool("Jumpp", true);
        }
        else
        {
            ani.SetBool("Jumpp", false);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            coinPoints += 1;
            //Debug.Log(coinPoints);
        }
        if (collision.CompareTag("diamond"))
        {
            Destroy(collision.gameObject);
            diamondPoints += 1;
            //Debug.Log(diamondPoints);
        }
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("deathcollider"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("Killers"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(groundCheck.position, groundCheck.localScale);
    }

}
