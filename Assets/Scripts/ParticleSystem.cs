using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + offset;
    }
}
