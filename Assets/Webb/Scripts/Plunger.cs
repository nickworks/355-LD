using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { };
public class Plunger : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody pinballRigidbody;
    private float force = 0;
    public float forcePerSecond = 100f;
    public float forceMaximum = 1000f;


    void Update()
    {
        if (pinballRigidbody != null && Input.GetButton("Plunger"))
        {
            force += forcePerSecond * Time.deltaTime;
            force = Mathf.Clamp(force, 0, forceMaximum);

        }
        if (pinballRigidbody != null && Input.GetButtonUp("Plunger"))
        {
            pinballRigidbody.AddForce(transform.forward * force, ForceMode.Impulse);
            print($"shoot ball with force amount: {force}");
            force = 0;
        }
    }
    void OnTriggerEnter(Collider collider)
    {

        if (pinballRigidbody == null && collider.transform.tag == "Pinball")
        {
            print("hit");
            pinballRigidbody = collider.GetComponent<Rigidbody>();
        }

    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<Rigidbody>() == pinballRigidbody)
        {
            pinballRigidbody = null;
        }
    }
}
