using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Johnson
{
    public class TiltControls : MonoBehaviour
    {
        public GameObject table;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // tilt left
            if (Input.GetButtonDown("Tilt"))
            {
                table.transform.rotation = Quaternion.Euler(table.transform.rotation.x, table.transform.rotation.y, -5);
            }
            if (Input.GetButtonUp("Tilt"))
            {
                table.transform.rotation = Quaternion.Euler(-9, table.transform.rotation.y, 0);
            }
            

            
        }
    }
}
