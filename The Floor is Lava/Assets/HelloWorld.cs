using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public string message = "Hello World!";
    public Vector3 scaleChange;
    public Vector3 rotateChange;
    void Start()
    {

        // Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(message);
        transform.localScale += scaleChange;
        transform.Rotate(rotateChange);
    }
}
