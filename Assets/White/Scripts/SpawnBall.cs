using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class SpawnBall : MonoBehaviour
    {
        public GameObject ball;
        public bool stopSpawning = false;

        public void Spawn()
        {
            Instantiate(ball, transform.position, transform.rotation);
            KillBall.ballIsDead = false;
            stopSpawning = true;
            if (stopSpawning)
            {
                KillBall.ballIsDead = false;
                CancelInvoke("Spawn");
            }

            if (KillBall.ballIsDead == true)
            {
                Invoke("Spawn", 5);
            }
        }
    }
}