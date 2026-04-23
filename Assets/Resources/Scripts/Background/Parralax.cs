using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Parralax : MonoBehaviour
{
    private float length, startPos;
    public new GameObject camera;
    public float parralaxEffect;

    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void FixedUpdate()
    {
        float distance = (camera.transform.position.x * parralaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.y);

    }
}
