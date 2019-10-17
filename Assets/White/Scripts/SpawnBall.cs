using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class SpawnBall : MonoBehaviour
    {
        public GameObject ball;
        public bool stopSpawning = false;

        void Start()
        {
            if (GameObject.Find("Pinball").GetComponent<KillBall>().ballIsDead == true)
            {
                Invoke("Spawn", 5);
            }
        }

        public void Spawn()
        {
            Instantiate(ball, transform.position, transform.rotation);
            stopSpawning = true;
            if (stopSpawning)
            {
                CancelInvoke("Spawn");
            }
        }
    }
}