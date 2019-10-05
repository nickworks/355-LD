using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperProperties : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint[] points = new ContactPoint[collision.contactCount];
        collision.GetContacts(points);

        Vector3 force = new Vector3();
        foreach (ContactPoint cp in points)
        {
            force += cp.normal;
        }
        force /= -points.Length;

        //Vector3 force = (collision.transform.position - transform.position).normalized;
        collision.rigidbody.AddForce(force * .9f, ForceMode.Impulse);
    }
}
