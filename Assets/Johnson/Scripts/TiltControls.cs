using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            table.transform.rotation = Quaternion.Euler(-10, table.transform.rotation.y, 1.5f);
        }
        if (Input.GetKeyUp("a") || Input.GetKeyUp("left"))
        {
            table.transform.rotation = Quaternion.Euler(-10, table.transform.rotation.y, 0);
        }

        // tilt right
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            table.transform.rotation = Quaternion.Euler(-10, table.transform.rotation.y, -1.5f);
        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("right"))
        {  
            table.transform.rotation = Quaternion.Euler(-10, table.transform.rotation.y, 0);
        }
    }
}
