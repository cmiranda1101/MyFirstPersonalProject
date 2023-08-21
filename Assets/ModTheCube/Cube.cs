using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubePosition = new Vector3(3, 4, 1);
    public float scaleMultiplier = 2.0f;
    public float rotateRate;
    public float red = 0.1f;
    public float green = 0.12f;
    public float blue = 0.9f;
    public float redChangeRate = 0.2f;
    public float greenChangeRate = 0.35f;
    public float blueChangeRate = 0.5f;
    public float alpha;
    void Start()
    {
        transform.position = cubePosition;
        transform.localScale = Vector3.one * scaleMultiplier;

        rotateRate = Random.Range (0.0f, 10.0f);
        
        

        InvokeRepeating("RandomRotate", 1.0f, .01f);
        InvokeRepeating("ColorChange", 1.0f, .01f);

    }
    
    void Update()
    {

    }
    void RandomRotate()
    {
        transform.Rotate(rotateRate * Time.deltaTime, 0.0f, 0.0f);
    }

    void ColorChange()
    {

        Material material = Renderer.material;

        material.color = new Color(red, green, blue, alpha);

        red += (redChangeRate * Time.deltaTime);
        green += (greenChangeRate * Time.deltaTime);
        blue += (blueChangeRate * Time.deltaTime);
    }
}
