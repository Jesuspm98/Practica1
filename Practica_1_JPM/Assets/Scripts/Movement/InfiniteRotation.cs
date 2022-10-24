using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRotation : MonoBehaviour
{
    public float rotationY;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, rotationY * Time.deltaTime, 0);
    }
}