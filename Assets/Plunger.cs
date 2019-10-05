using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plundger : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    void Start()
    {

        body = GetComponent<Rigidbody>();
    }
    bool plunger = false;
    public int force = 0;
    void Update()
    {
        if (plunger = true && Input.GetButton("Plunger"))
        {
            force += 1;
            
        }
        if (plunger = true && Input.GetButtonUp("Plunger"))
        {
            body.AddForce(transform.up * force);
           
        }
    }
    void OnTriggerEnter(Collider collider)
    {
           
        if (collider.transform.tag == "Pinball)")
        {
            print("help");
            plunger = true;
        }




    }
}
