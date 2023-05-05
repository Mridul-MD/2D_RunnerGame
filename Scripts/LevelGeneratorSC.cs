using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class LevelGeneratorSC : MonoBehaviour
{
    public static LevelGeneratorSC instance;

    [SerializeField] Transform Starting_block1;
    [SerializeField] List<Transform> blockLists;
    public Vector3 Block1_endpointPosition;
    Transform chooseLevelPart;
    private void Awake()
    {
        if(instance== null)
        {
            instance = this;
        }else
        {
            Destroy(gameObject);
        }

        Block1_endpointPosition = Starting_block1.Find("endpoint").position;
        int startingSpawnLevelParts = 1;

        for (int i=0; i<startingSpawnLevelParts; i++)
        {
            spawnLevelParts(Block1_endpointPosition);
        }
    }
    public void spawnLevelParts(Vector3 endPointPosition)
    {
        chooseLevelPart = blockLists[Random.Range(0,blockLists.Count)];
        Transform endpoint_starating_block = SpawnBlock(chooseLevelPart, endPointPosition);
    }
    private Transform SpawnBlock(Transform levelpart, Vector3 spawningPoint)
    {
        Transform B = Instantiate(levelpart, spawningPoint, Quaternion.identity);
        return B;
    }

}
