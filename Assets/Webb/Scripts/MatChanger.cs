using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class MatChanger : MonoBehaviour
    {
        public Material newMaterialRef;
        static public bool wood = false;
        public int gatherdMaterials = 50;
        public int times = 0;
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
 Renderer rend = GetComponent<Renderer>();
            if (HUDControler.wood >= gatherdMaterials )
            {
                if (wood == false)
                {
                 HUDControler.multiplier += times;
                }
                
                rend.material = newMaterialRef;
                wood = true;
            }
        }
    }
}