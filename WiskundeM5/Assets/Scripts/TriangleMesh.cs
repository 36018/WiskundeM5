using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMesh : MonoBehaviour
{
    
    Mesh mesh;



    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        mesh.vertices = new Vector3[]
        {
            new Vector3 (0,0,0), //0
            new Vector3 (2,0,0), //1
            new Vector3 (1,2,0), //2
            new Vector3 (0,1,0), //3
            new Vector3 (-2,-1,0), //4
            new Vector3 (-2,-2,-1), //5
        };
        mesh.triangles = new int[]
        {
            0,1,2,
            5,4,0,
            2,3,5
        };

    }
}
