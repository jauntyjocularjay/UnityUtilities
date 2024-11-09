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
            result = new Vector3(
                result.x * vectors[i].x,
                result.y * vectors[i].y,
                result.z * vectors[i].z
            );
        }

        return result;
    }

    static public Vector3 Divide(List<Vector3> vectors)
    {
        Vector3 result = vectors[0];

        for(int i = 1; i < vectors.Count; i++)
        {
            result = new Vector3(
                result.x / vectors[i].x,
                result.y / vectors[i].y,
                result.z / vectors[i].z
            );
        }
        return result;
    }

}
