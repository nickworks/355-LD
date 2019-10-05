using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerController : MonoBehaviour
{
    Rigidbody body;
    Vector3 plungerDirection = new Vector3(0,100,0);
    int counter;
    int counterMax = 15;
    Quaternion rotation = Quaternion.Euler(90, 0, 0);

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
            body.transform.rotation = rotation;
            body.AddForce(Vector3.up * 10 * counter);
            counter = 0;
            Vector3 pos = body.transform.position;
            pos.y = Mathf.Clamp(transform.position.y, 0, .2f);
            body.transform.position = pos;
        }

        
    }
}
