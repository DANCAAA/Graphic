using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityForce : MonoBehaviour
{
    [SerializeField]
    float Factor;
    public Transform target;
 

    // Use this for initialization
    void Start ()
    {
        double G = 6.67408 * Factor;
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TargetDirection = target.position - transform.position;
        float angle = Vector3.Angle(TargetDirection, transform.forward);
        if (angle > 0.01f)
        {
            print("Excuting gravity atraction");
            
        }
    }

    void FixedUpdate()
    {   
    }
}
