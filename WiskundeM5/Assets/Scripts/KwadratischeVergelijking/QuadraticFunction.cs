using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticFunction : MonoBehaviour
{
    public float a;
    public float b;
    public float c;

    public QuadraticFunction(float a, float b, float c)
    {
        this.a = a; this.b = b; this.c = c;
    }

    public Vector2 findZero()
    {
        Vector2 isZero = new Vector2();
        float D = (this.b * this.b) - (4 * this.a * this.c);
        if (D < 0)
        {
            //throw new InvalidOperationException("Geen re�le oplossingen voor deze vergelijking.");
        }
        else
        {
            isZero.x = (-this.b + Mathf.Sqrt(D)) / (2 * this.a);
            isZero.y = (-this.b - Mathf.Sqrt(D)) / (2 * this.a);
        }

        return isZero;
    }

}