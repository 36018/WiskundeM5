using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] GameObject Ball;

    Vector3 velocity = new Vector3 (2, 3, 0);
    Vector3 acceleration = new Vector3 (0, -1, 0 );

    Vector2 min;
    Vector2 max;
    
    void Start()
    { 
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));


    }

    void Update()
    {
        velocity += acceleration * Time.deltaTime;
        Ball.transform.position += velocity * Time.deltaTime;

        if(Ball.transform.position.y > max.y - Ball.transform.localScale.y/2f)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }

        if (Ball.transform.position.x > max.x - Ball.transform.localScale.x / 2f)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }

        if (Ball.transform.position.y < min.y + Ball.transform.localScale.y / 2f)
        {
            Ball.transform.position = new Vector3(Ball.transform.position.x, min.y + Ball.transform.localScale.y / 2f, 0 );
            velocity = new Vector3(velocity.x, -velocity.y, 0);
            
        }

        if (Ball.transform.position.x < min.x + Ball.transform.localScale.x / 2f)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }


    }
}
