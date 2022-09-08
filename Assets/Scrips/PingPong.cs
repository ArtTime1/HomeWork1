using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public float speed, range;
    Vector3 startPosition;

    Transform player;
    Vector3 direction = Vector3.right;


    void Start()
    {
        player = gameObject.GetComponent<Transform>();
        startPosition = player.position;

    }


    void Update()
    {

        player.Translate(direction * speed * Time.deltaTime);

        if (player.position.x <= startPosition.x - range)
        {
            direction = Vector3.right;
        }

        else if (player.position.x >= startPosition.x + range)
        {
            direction = Vector3.left;
        }


    }
}
