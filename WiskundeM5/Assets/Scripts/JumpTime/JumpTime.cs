using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JumpTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI time;
    [SerializeField] GameObject brick;

    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    enum States { wait, active, finished };
    States myState = States.wait;

    float t = 0;
    float y0;

    // Start is called before the first frame update
    void Start()
    {
        time.text = t.ToString();
        y0 = brick.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.wait) 
        { 
            if (Input.GetMouseButtonDown(0))
            {
                acceleration = new Vector3(0, -2, 0);
                velocity = new Vector3(0, 5, 0);
                myState = States.active;
            }
        }

        if (myState == States.active)
        {
            velocity += acceleration * Time.deltaTime;
            brick.transform.position += velocity * Time.deltaTime;
            t += Time.deltaTime;
            time.text = t.ToString("F3");
            if (brick.transform.position.y < y0)
            { 
                myState = States.finished;
            }
        }

        if (myState == States.finished)
        {
            brick.transform.position = new Vector3(brick.transform.position.x, y0 , 0);
            myState = States.wait;
            t = 0;
        }
    }
}
