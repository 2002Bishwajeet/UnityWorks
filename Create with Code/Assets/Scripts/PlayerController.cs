using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        // transform.Translate(0, 0, 1);
        /* 
            Translate has actually 5 overloads so the above was one of the method of doing 
            This time we will use vector3 . Vector3.forward is actually the short form of the above one
         */
        //transform.Translate(Vector3.forward); Problem here is its updating every single frame, so depends on the speed of computer
        // You would be getting different frames
        // Let's see a method where let's control this thing . we will use vector3.forward but just we 
        // will multiply with time now.
        transform.Translate(Vector3.forward * Time.deltaTime*speed);


    }
}
