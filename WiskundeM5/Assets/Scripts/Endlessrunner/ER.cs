using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER : MonoBehaviour
{
    [SerializeField] GameObject runner;
    Animator animator;

    enum State { run, jump};

    State myState = State.run;

    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;

    float y0;

    void Start()
    {
        animator = runner.GetComponent<Animator>();
        animator.speed = 0.5f;
        y0 = runner.transform.position.y;
    }
    void Update()
    {
        if (myState == State.run)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myState = State.jump;
                velocity = new Vector3(0,(0.75f * 10) / 4 ,0);
                acceleration = new Vector3(0,-5,0);
            }
        }

        if (myState == State.jump)
        {
            velocity += acceleration * Time.deltaTime;
            runner.transform.position += velocity * Time.deltaTime;
            animator.Play("jump1");
                if (runner.transform.position.y < 0)
                {
                    runner.transform.position = new Vector3(runner.transform.position.x, y0, 0);
                }
                myState = State.run;
        }
    }
}
