using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControlsWiles : MonoBehaviour
{
    public float maxTilt = 6.5f;
    public float minTilt = -6.5f;
    Transform defaultTrans;
    // Start is called before the first frame update
    void Start()
    {
        defaultTrans = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion maxQuart = Quaternion.Euler(-6.5f, 0, maxTilt);
        Quaternion minQuart = Quaternion.Euler(-6.5f, 0, minTilt);
        Quaternion defQuart = Quaternion.Euler(-6.5f, 0, 0);
        if (Input.GetAxisRaw("Tilt") == -1) transform.localRotation = maxQuart;
        if (Input.GetAxisRaw("Tilt") == 1) transform.localRotation = minQuart;
        if (Input.GetAxisRaw("Tilt") == 0) transform.rotation = defQuart;
        //print("Horizontal is down!");
        /*
        float tilt = -(Input.GetAxisRaw("Horizontal"));
        Transform tiltTrans = transform;
        tiltTrans.eulerAngles = Vector3.Lerp(tiltTrans.eulerAngles, new Vector3(tiltTrans.eulerAngles.x, tiltTrans.eulerAngles.y, maxTilt * tilt), .65f);
        print(tiltTrans.eulerAngles);
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, tiltTrans.eulerAngles, .65f);
        */

        /*
        float h = Input.GetAxisRaw("Horizontal");
        Transform tiltTrans = transform;
        transform.Rotate(0, 0, h);
        Vector3 currentRot = transform.rotation.eulerAngles;
        currentRot.z = Mathf.Clamp(currentRot.z, minTilt, maxTilt);
        transform.rotation = Quaternion.Euler(currentRot);
        */

        /*
        if (transform.rotation.z < -maxTilt)
        {
            float turnBack = (transform.rotation.z - -maxTilt);
            transform.Rotate(0, 0, -turnBack);
        }
        if (transform.rotation.z > maxTilt)
        {
            float turnBack = (transform.rotation.z - maxTilt);
            transform.Rotate(0, 0, -turnBack);
        }
        */
        //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, defaultTrans.eulerAngles, .65f);
        //print("Update End!");
    }
}
