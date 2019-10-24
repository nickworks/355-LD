using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class SpawnObjects : MonoBehaviour
    {
        public GameObject objectType;
        public bool timedSpawn = false;
        public bool stopSpawning = false;
        public float spawnTime;
        public float spawnDelay;

        // Start is called before the first frame update
        void Start()
        {
            if (timedSpawn == true)
            {
                InvokeRepeating("SpawnBumper", spawnTime, spawnDelay);
            }
        }

        // Update is called once per frame
        public void SpawnBumper()
        {
            Instantiate(objectType, transform.position, transform.rotation);
            stopSpawning = true;
            if (stopSpawning)
            {
                CancelInvoke("SpawnBumper");
            }
        }
    }
}