using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Async : MonoBehaviour
{
    [SerializeField] float beginSpeed = 5;
    [SerializeField] float gravity = 10;

    enum State { run, jump };

    State myState = State.run;

    Animator Animator;
    float t = 0f;
    float tmax;

    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == State.run)
        {
            Animator.Play("run");
            if (Input.GetMouseButtonUp(0))
            {
                myState = State.jump;
                t = 0;
                velocity = new Vector3(0, beginSpeed, 0);
                acceleration = new Vector3(0, -gravity, 0);
                tmax = 2 * beginSpeed / gravity;
                Animator.speed = 0.75f / tmax;
            }
        }

        if (myState == State.jump)
        {
            velocity += acceleration * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;

            Animator.Play("jump");
            t += Time.deltaTime;
            if (t> tmax)
            {
                myState = State.run;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
            }
        }
    }
}
