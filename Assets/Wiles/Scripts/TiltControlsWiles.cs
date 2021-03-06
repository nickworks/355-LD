﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class TiltControlsWiles : MonoBehaviour
    {
        public float maxTilt = 6.5f;
        public float minTilt = -6.5f;
        Transform defaultTrans;
        Quaternion maxQuart;
        Quaternion minQuart;
        Quaternion defQuart;



        public GameObject gameRef;
        GameValues gameValue;
        // Start is called before the first frame update
        void Start()
        {
            gameValue = gameRef.GetComponent<GameValues>();

            defaultTrans = transform;
            maxQuart = Quaternion.Euler(-6.5f, 0, maxTilt);
            minQuart = Quaternion.Euler(-6.5f, 0, minTilt);
            defQuart = Quaternion.Euler(-6.5f, 0, 0);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxisRaw("Tilt") == 0) transform.rotation = Quaternion.Slerp(transform.rotation, defQuart, 0.65f);

            if (gameValue.gameOver) return;
            //Quaternion targetQuart = new Quaternion(0, 0, 0, 0);
            //Quaternion testQ = Quaternion.Slerp(transform.rotation, targetQuart, 0.65f);
            
            if (Input.GetAxisRaw("Tilt") == -1) transform.rotation = Quaternion.Slerp(transform.rotation, maxQuart, 0.65f);
            if (Input.GetAxisRaw("Tilt") == 1) transform.rotation = Quaternion.Slerp(transform.rotation, minQuart, 0.65f);
            
            
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
}