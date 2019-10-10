using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class BallBounce : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnCollisionEnter(Collision col)
        {
            var ob = col.gameObject;

            print(ob);
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
