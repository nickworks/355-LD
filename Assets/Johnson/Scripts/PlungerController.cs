using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerController : MonoBehaviour
{
    Rigidbody body;
    Vector3 plungerDirection = new Vector3(0,100,0);
    int counter;
    int counterMax = 50;
    Quaternion rotation = Quaternion.Euler(-90, 0, 0);

    void Start()
    {
        body = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        


        if (Input.GetButton("Plunger"))
        {
            counter++;
            if(counter > counterMax)
            {
                counter = counterMax;
            }
        }
        if (Input.GetButtonUp("Plunger"))
        {
            
            
            
                if (transform.position.z <= -.4f)
                {
                Vector3 plungering = transform.TransformDirection(Vector3.forward * counter/2);
                body.AddForce(plungering, ForceMode.Impulse);
                counter = 0;
                }
                

        }
        if (body.transform.position.z >= -.45f)
        {
            body.transform.position = new Vector3(body.transform.position.x, body.transform.position.y, -.45f);
            body.AddForce(Vector3.back, ForceMode.Impulse);
        }


    }
}
