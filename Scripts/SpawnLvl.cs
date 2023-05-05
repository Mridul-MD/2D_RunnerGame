using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLvl : MonoBehaviour
{
    [SerializeField] Transform endpointPOS;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            LevelGeneratorSC.instance.spawnLevelParts(endpointPOS.position);

        }
    }

}
