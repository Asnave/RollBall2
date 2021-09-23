using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Ball.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Ball.transform.position + offset;
    }
}
