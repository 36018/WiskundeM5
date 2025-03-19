using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inertia : MonoBehaviour
{
    [SerializeField] GameObject B1;
    [SerializeField] GameObject B2;

    Rigidbody rb1;
    Rigidbody rb2;
    void Start()
    {
        rb1 = B1.GetComponent<Rigidbody>();
        rb2 = B2.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb1.AddForce(new Vector3 (1, 0, 0) * 100f, ForceMode.Force);
            rb2.AddForce(new Vector3 (1, 0, 0) * 100f, ForceMode.Force);
        }
    }
}
