using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class allows the player to charge up the plunger in order to launch the ball into play.
 */
public class ChargePlunger : MonoBehaviour
{
    Rigidbody body;
    public float plungerStrength = 0;
    private Vector3 plungerWindup;

    /*
     * This function gets the Rigidbody and stores it into its variable.
     */
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    /*
     * This function updates the plunger.
     */
    void Update()
    {
        if(Input.GetButton("Plunger"))
        {
            plungerStrength += 100 * Time.deltaTime;
            plungerStrength = Mathf.Clamp(plungerStrength, 0, 1000);

            body.transform.position = plungerWindup;
        }

        if(Input.GetButtonUp("Plunger"))
        {

        }
    }
}
