using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class TriggerBump : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            ContactPoint[] points = new ContactPoint[collision.contactCount];
            collision.GetContacts(points);

            Vector3 force = new Vector3();
            foreach (ContactPoint cp in points)
            {
                force += cp.normal;
            }
            force /= -points.Length;

            force.Normalize();

            collision.rigidbody.AddForce(force * 10, ForceMode.Impulse);

            ScoreManager.score++;
        }
    }
}