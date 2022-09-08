using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotate = new Vector3(1f, 0f, 0f);
    

    void Start()
    {
        
    }

    
    void Update()
    {
        Quaternion rotation = Quaternion.AngleAxis(1f, Vector3.left);
        transform.rotation *= rotation;
        

    }
}
    