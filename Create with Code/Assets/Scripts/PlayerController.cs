using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float speed = 20.0f;
    private const float turnSpeed= 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Input is actually a class which we are using the GetAxis method to get konsa Axis
        // use karna hai so in this case we are using horizontal. I will make for vertical now too
        horizontalInput = Input.GetAxis("Horizontal");

        // For forwardInput
        forwardInput = Input.GetAxis("Vertical");

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
        // transform.Translate(Vector3.forward * Time.deltaTime*speed);

        // Pehle upar waale case mein  it moves forward without pressing any key
        // now we will work on a similar approach but use keys now
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We are adding some turn speed now so that vehicles can move left or right now
        //  transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Now the issue is the vehicle is sliding instead of rotating. Let's do something about it
        //Vector3.up is Y axis
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


    }
}
