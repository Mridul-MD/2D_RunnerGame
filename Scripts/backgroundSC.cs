using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSC : MonoBehaviour
{

    private MeshRenderer mesh;
    [SerializeField] float speed;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
