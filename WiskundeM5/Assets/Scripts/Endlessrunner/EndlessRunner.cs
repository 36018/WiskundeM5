using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    [SerializeField] GameObject runner;
    Animator animator;

    enum State { grounded, airborne};
    State myStated = State.grounded;

    float y0;
    Vector3 velocity = Vector3.zero;
    Vector3 gravity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        animator = runner.GetComponent<Animator>();
        y0 = runner.transform.position.y;
        animator.speed = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myStated == State.grounded)
        {
            if (Input.GetMouseButtonUp(0))
            {
                velocity = new Vector3(0, 14, 0);
                gravity = new Vector3(0, -20, 0);
                myStated = State.airborne;
                animator.speed = 0;
            }
        }
        if (myStated == State.airborne)
        {
            velocity += gravity * Time.deltaTime;
            runner.transform.position += velocity * Time.deltaTime;
            if (transform.position.y < 0)
            {
                velocity = Vector3.zero;
                gravity = Vector3.zero;
                runner.transform.position = new Vector3(runner.transform.position.x, y0, 0);
                myStated = State.grounded;
                animator.speed = 1;
            }
        }
    }
}
