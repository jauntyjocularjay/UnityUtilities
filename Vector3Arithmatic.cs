using System.Collections.Generic;
using UnityEngine;

/*
 * 2024 github @ Jauntyjocularjay
 * Vector3Arithmatic is a suite of operations to make processing vectors easier.
 * License: MIT
*/
public class Vector3Arithmatic
{
    static public Vector3 Multiply(List<Vector3> vectors)
    {
        Vector3 result = vectors[0];

        for(int i = 1; i < vectors.Count; i++)
        {
            float x = result.x;
            float y = result.y;
            float z = result.z;

            x *= vectors[i].x;
            y *= vectors[i].y;
            z *= vectors[i].z;

            result = new Vector3(x,y,z);
        }
        return result;
    }

    static public Vector3 Divide(List<Vector3> vectors)
    {
        Vector3 result = vectors[0];

        for(int i = 1; i < vectors.Count; i++)
        {
            float x = result.x;
            float y = result.y;
            float z = result.z;

            x /= vectors[i].x;
            y /= vectors[i].y;
            z /= vectors[i].z;

            result = new Vector3(x,y,z);
        }
        return result;
    }

}
