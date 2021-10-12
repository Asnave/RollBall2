using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;


    private void Start()
    {

        currentTime = startingTime;

    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
    }


}
