using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUnityComponets : MonoBehaviour
{
    public MeshRenderer mesh;

    public Collider[] coliders;

    // Start is called before the first frame update
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        coliders = GetComponents<Collider>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}