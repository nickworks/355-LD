using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        if (target == null) return;
        transform.position = Vector3.Lerp(transform.position, target.position, .1f);
    }
}
