using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReseter : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision col)
    {
        var ob = col.gameObject;
        print(ob);
        var wallHit = ob.GetComponent<BallReseterWall>();
        if (wallHit == null)
        {
            return;
        } else {
            if (wallHit.moveWhileReset) transform.SetPositionAndRotation(new Vector3(0.243f, 0.03f, -0.4f), new Quaternion());
            var bLauncher = GetComponent<BallLauncher>();
            bLauncher.Reset();
        }
    }
}
