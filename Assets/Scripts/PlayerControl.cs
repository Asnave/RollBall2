using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public GameObject restart;
    
    public PlayerControl movement;

    private float movementX;
    private float movementY;
    public Rigidbody rb;
    private int count;

    public static bool GameIsPaused = false;
    
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        

        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        restart.SetActive(false);
      
    }

    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void SetCountText()
    {
        countText.text = "SCORE " + count.ToString();
    }
   

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    private void Update()
    {
        rb.AddForce(0, 0, 6);
        rb.AddForce(0, -15, 0);

        
    }
    
    private void OnTriggerEnter(Collider other)
    {
            

            if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();

        }

        if (other.gameObject.CompareTag("End"))
        {


            if (count < 20)
            {
                loseTextObject.SetActive(true);
                winTextObject.SetActive(false);
            }

            if (count >= 20)
            {
                winTextObject.SetActive(true);
                loseTextObject.SetActive(false);
            }
            
            restart.SetActive(true);
            
        }

       

    }
}
