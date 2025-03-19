using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    Animator animator;
    Vector3 acceleration = Vector3.zero;
    Vector3 velocity = Vector3.zero;

    float g = 10f;
    float vb = 9f;
    float hb = 4f;

    enum States { wait, jump, finished};
    States myState = States.wait;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.wait) 
        {
            if (Input.GetMouseButtonUp(0)) 
            {
                acceleration = new Vector3 (0, -g, 0);
                velocity = new Vector3 (3, vb, 0);
                myState = States.jump;
            }
        }
        if (myState == States.jump)
        {
            velocity += acceleration * Time.deltaTime;
            //transform.position
        }
        if (myState == States.finished)
        {

        }
    }
}
