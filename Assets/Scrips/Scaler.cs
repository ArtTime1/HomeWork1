using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public Vector3 maxsize = new Vector3(2f, 2f, 2f);
    public float speed = 0.1f;
    
    
   

    void Start()
    {
        
    }

    void Update()
    {
        
        transform.localScale = Vector3.Lerp(transform.localScale , maxsize , speed *Time.deltaTime);
      
        
    }
}
