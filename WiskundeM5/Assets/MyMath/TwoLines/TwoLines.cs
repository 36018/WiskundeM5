using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLines : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform C;
    [SerializeField] Transform D;
    [SerializeField] LineRenderer AB;
    [SerializeField] LineRenderer CD;

    LinearFunction f = new LinearFunction(1,1);
    LinearFunction g = new LinearFunction(1,1);

    [SerializeField] Transform S;
    // Start is called before the first frame update
    void Start()
    {
        f.SetFunctionWithTwoPoints(A.position, B.position);
        AB.SetPosition(0, new Vector3(-10, f.getY(-10), 0));
        AB.SetPosition(0, new Vector3(-10, f.getY(10), 0));

        g.SetFunctionWithTwoPoints(C.position, D.position);
        CD.SetPosition(0, new Vector3(-10, f.getY(-10), 0));
        CD.SetPosition(0, new Vector3(-10, f.getY(10), 0));

        S.position = f.intersection(g);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
