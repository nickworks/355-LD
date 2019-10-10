using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class TriggerBump : MonoBehaviour
    {
        public int bumperForce = 800;
        public GameObject player;

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject == player)
            {
                player.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);
            }
        }
    }
}