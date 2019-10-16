using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class Tilt : MonoBehaviour
    {
        Vector3 tilt;
        // Start is called before the first frame update
        void Start()
        {
            tilt = new Vector3(0, 0, 1);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Horizontal"))
            {
                transform.Rotate(0, 0, 2, Space.Self);
                
            }
            if (Input.GetButtonUp("Horizontal"))
            {
                transform.Rotate(0, 0, -2, Space.Self);

            }
            if (Input.GetButtonDown("Vertical"))
            {
                transform.Rotate(2, 0, 0, Space.Self);

            }
            if (Input.GetButtonUp("Vertical"))
            {
                transform.Rotate(-2, 0, 0, Space.Self);

            }
        }

    }
}