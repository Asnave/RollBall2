using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lurp : MonoBehaviour
{
    MeshRenderer cubeMeshRenderer;
    [SerializeField] [Range(0f, 100f)] float lerpTime;

    [SerializeField] Color[] myColors;

    int colorIndex = 0;

    float t = 0f;

    int len;

    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = GetComponent<MeshRenderer>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t>.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex; 
        }
    }
}
