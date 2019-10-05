using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plundger : MonoBehaviour
{
    // Start is called before the first frame update
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

        //Vector3 force = (collision.transform.position - transform.position).normalized;
        collision.rigidbody.AddForce(force , ForceMode.Impulse);
        print("anything");
    }
}
