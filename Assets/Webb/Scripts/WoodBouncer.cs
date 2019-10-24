using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class WoodBouncer : MonoBehaviour
    {
        public float forcemultiplier = 20;
        void OnCollisionEnter(Collision collision)
        {
            HUDControler.wood += 1;
            HUDControler.score += 50 * HUDControler.multiplier;
            ContactPoint[] points = new ContactPoint[collision.contactCount];
            collision.GetContacts(points);
            Vector3 force = new Vector3();
            foreach (ContactPoint cp in points)
            {
                force += cp.normal;
            }
            force /= -points.Length;

            //Vector3 force = (collision.transform.position - transform.position).normalized;
            collision.rigidbody.AddForce(force * forcemultiplier, ForceMode.Impulse);

        }
    }
}