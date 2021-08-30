using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // things like obstacle or vehicle are gameObject so we are using this 
    // to get references
    // Also kept public so that we can access this variable in unity
    public GameObject player;
    // Start is called before the first frame update

    // We don't want to change this value so don't want to access this in unity
    private Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    // Currently if we use update the camera update is not so smooth. To make it smooth
    // we should use late update. cause dono moving at same time, so sometimes camera updates first
    // then the vehicle so ek ko late update so to smooth things out
    void LateUpdate()
    {
      
        // Abhi currently this is below the car cause that's how we positioned 
        // transform.position = player.transform.position;

        // Let's now add an offset here cause we don't want the above result
        transform.position = player.transform.position + offset;
        // So adding a little offset. We can't add (x,y,z) like this cause computer ko bhi 
        // Smjh mein aana chaiye
        
    }
}
