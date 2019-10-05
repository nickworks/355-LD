using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerImpulse : MonoBehaviour
{

    float counter;
    float counterMax = 3.2f;
    public Rigidbody body;
    





    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Plunger"))
        {
            counter = 0;
        }
        if (Input.GetButton("Plunger"))
        {
            if (counter > counterMax)
            {
                counter = counterMax;
            }
            else
            {
                counter += .02f;
            }
            
        }
        else if (Input.GetButtonUp("Plunger"))
        {
            body.AddForce(Vector3.forward * counter, ForceMode.Impulse);
        }
        
    }
}
