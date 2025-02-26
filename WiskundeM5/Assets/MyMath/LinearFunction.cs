using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction
{
    public float slope;
    public float intercept;

    public LinearFunction(float slope, float intercept)
    {
        this.slope = slope;
        this.intercept = intercept;
    }

    public float getY(float x) 
    {
        return slope * x + intercept;
    }

    public void SetFunctionWithTwoPoints(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y) /(B.x - A.x);

        // y = slope * x + intercept
        // y - slope * x = intercept
        this.intercept = B.y - B.x * this.slope;

    }

    public Vector3 intersection(LinearFunction g)
    {
        float x_s = (this.intercept - g.intercept)/(g.slope - this.slope);
        float y_s = this.slope * x_s + this.intercept;

        return new Vector3(x_s, y_s, 0);
    }
}
