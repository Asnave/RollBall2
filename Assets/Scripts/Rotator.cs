using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject pickupEffect;

    private void Start()
    {
        pickupEffect.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickupEffect.SetActive(true);
            Collectable();
        }
    }

    void Collectable()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }
}
