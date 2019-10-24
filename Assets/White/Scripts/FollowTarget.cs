using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    /*
     * This class makes the camera follow the ball as it moves.
     */
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;

        /*
         * This function makes the camera update its position as the ball moves.
         */
        void FixedUpdate()
        {
            if (target == null) return;
            transform.position = Vector3.Lerp(transform.position, target.position, .1f);
        }
    }
}