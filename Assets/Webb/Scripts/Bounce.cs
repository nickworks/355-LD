using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { };
public class Bounce : MonoBehaviour
{ 
    public float forcemultiplier = .002f;
    void OnCollisionEnter(Collision collision)
    {
        HUDControler.score += 50;
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
