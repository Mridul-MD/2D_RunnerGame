using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMotionSC : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    private float leftedge;

    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 200f;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if ( transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
    }

}
