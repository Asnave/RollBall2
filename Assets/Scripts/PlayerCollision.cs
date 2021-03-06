using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public PlayerControl movement;
    public Rigidbody rb;
    public GameObject restart;
    public GameObject loseTextObject;
    public GameObject winTextObject;
    public static bool GameIsPaused = false;

    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            GameIsPaused = false;
            movement.enabled = false;
            restart.SetActive(true);
            loseTextObject.SetActive(true);
            winTextObject.SetActive(false);
            rb.velocity = Vector3.zero; 

            if (loseTextObject == true)
            {
                winTextObject.SetActive(false);
            }
        }
        
       if (collisionInfo.collider.tag == "End")
        {
        
            movement.enabled = false;
        }
    }

}
