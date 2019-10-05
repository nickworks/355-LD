using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    private bool inPlay;
    public float force = 0;
    Rigidbody body;
    public float maxForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        inPlay = false;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            inPlay = false;
            force = 0;
        }
        if (!inPlay)
        {
            if (Input.GetButton("Plunger"))
            {
                force = force + Time.deltaTime;
                if (force > maxForce) force = maxForce;
            }
            if (Input.GetButtonUp("Plunger"))
            {
                body.AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
                inPlay = true;
            }
        }
    }
}
