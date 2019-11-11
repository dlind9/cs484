using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTracer : MonoBehaviour
{
    //public Vector3 b;
    public class Ray
    {
        public Vector3 A;
        public Vector3 B;
        public Ray() 
        {
               
        }
        public Ray(Vector3 a, Vector3 b)
        {
            A = a;
            B = b;
        }
        Vector3 origin()
        {
            return A;
        }
        Vector3 direction()
        {
            return B;
        }
        Vector3 point_at_parameter(float t)
        {
            return A + t * B;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        //Ray ray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
