using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 move = new Vector3(0f, 0f, 0f);
    double timer;
   
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (timer >= 2)
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), Random.Range(0f, 3f), Random.Range(-3f, 3f));
            
            timer = 0;
        }

        
        timer += Time.deltaTime;
    }
}
