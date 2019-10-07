using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopper : MonoBehaviour
{
    public Rigidbody ball;

    private void OnTriggerEnter(Collider other)
    {
        
        ball.isKinematic = true;
    }

}
