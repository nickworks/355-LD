using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class SpawnObjects : MonoBehaviour
    {
        public GameObject bumper;
        public bool stopSpawning = false;
        public float spawnTime;
        public float spawnDelay;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SpawnBumper", spawnTime, spawnDelay);
        }

        // Update is called once per frame
        public void SpawnBumper()
        {
            Instantiate(bumper, transform.position, transform.rotation);
            stopSpawning = true;
            if (stopSpawning)
            {
                CancelInvoke("SpawnBumper");
            }
        }
    }
}