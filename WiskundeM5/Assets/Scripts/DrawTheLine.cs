using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DrawTheLine : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    LinearFunction f = new LinearFunction(1,1);

    [SerializeField] DraggeblePoint A;
    // Start is called before the first frame update
    void Start()
    {
        A.color = Color.green;
        f.slope = 0.5f;
        f.intercept = 0f;

        lineRenderer.SetPosition(0, new Vector3(-3, f.getY(-3), 0));
        lineRenderer.SetPosition(1, new Vector3(3, f.getY(3), 0));

        //y = 0.5 * -3
        //y = helling * X + begingetal
        //y = slope * X + intercept
        
    }

    // Update is called once per frame
    void Update()
    {
        if (A.transform.position.y > f.getY(A.transform.position.x))
        {
            A.color = Color.red;
        }
        else
        {
            A.color = Color.green;
        }
    }
}
