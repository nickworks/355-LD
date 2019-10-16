using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wiles;

namespace Wiles
{
    public class BallBounce : MonoBehaviour
    {

        public GameObject game;
        GameValues gameScore;

        // Start is called before the first frame update
        void Start()
        {
            gameScore = game.GetComponent<GameValues>();
        }

        // Update is called once per frame
        void Update()
        {
 
        }
        void OnCollisionEnter(Collision col)
        {

            gameScore.scoreUp(1);

            var ob = col.gameObject;

            //print(ob);
            var wallHit = ob.GetComponent<BouncyObject>();
            if (wallHit == null)
            {
                //print("Not Bouncey)");
                return;
            }
            else
            {
                //print("BOUNCE!?");

                //Vector3 force = (col.transform.position - transform.position).normalized;

                gameScore.multUp(1);

                ContactPoint[] points = new ContactPoint[col.contactCount];
                col.GetContacts(points);

                Vector3 force = new Vector3();
                foreach (ContactPoint cp in points)
                {
                    force += cp.normal;
                }
                force /= -points.Length;

                var bLauncher = GetComponent<BallLauncher>();
                bLauncher.Bounce(force, wallHit.bouncyAmmount);
            }
        }
    }
}
