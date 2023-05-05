using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireing : MonoBehaviour
{
    [SerializeField] GameObject fireball;
    [SerializeField] Transform SpawnPoint;
    private GameObject player;
    private float distance;
    private float timer;
    [SerializeField] private int FireRate = 2;
    [SerializeField] private int PlayerDistance = 40;

    //private fireballscript fireballscript;
    //[SerializeField] int adddamagetofireball;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //fireballscript = fireball.gameObject.GetComponent<fireballscript>();
        //fireballscript.adddamage = adddamagetofireball;
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < PlayerDistance)
        {
            timer += Time.deltaTime;

            if (timer > FireRate)
            {

                timer = 0;
                shoot();
            }
        }
    }

    void shoot()
    {
        Instantiate(fireball, SpawnPoint.transform.position, Quaternion.identity);

    }
}
