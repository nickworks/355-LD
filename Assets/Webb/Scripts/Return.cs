using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class Return : MonoBehaviour
    {
        public static Vector3 startPos;

        // Start is called before the first frame update
        void Start()
        {
            startPos = gameObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider collider)
        {

            if (collider.transform.tag == "Return")
            {
                HUDControler.lives -= 1;
                if (HUDControler.lives > 0)
                {
                    gameObject.transform.position = startPos;

                }
            }
        }
    }
}