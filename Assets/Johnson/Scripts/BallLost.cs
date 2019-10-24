using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Johnson
{
    public class BallLost : MonoBehaviour
    {
        bool isBallGone = false;
        Scene scene;

        private void OnTriggerEnter(Collider other)
        {

            isBallGone = true;
            
        }

        private void Update()
        {
            if (isBallGone)
            {
                if (Input.GetButtonDown("Reset"))
                {
                    isBallGone = false;


                }
            }

        }
    }
}