using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kwadraticfunction 
{
    public float a;
    public float b;
    public float c;

    public Kwadraticfunction(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Vector2 findZero()
    {
        Vector2 IsZero = new Vector2();
        float D = (this.b * this.b) - (4 * this.a * this.c);
        if (D < 0)
        {
            IsZero = Vector2.zero;
        }
        else
        { 
            IsZero.x = (-this.b + Mathf.Sqrt(D))/(2 * this.a);
            IsZero.y = (-this.b - Mathf.Sqrt(D)) / (2 * this.a);
        }
        return IsZero;
    }
}
