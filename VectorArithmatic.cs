using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

/*
 * 2024 GitHub @ jauntyjocularjay
 * Vector3Arithmatic is a suite of operations to make processing vectors easier.
 * License: MIT
*/
public class VectorArithmatic
{
    static public Vector3 Multiply(List<Vector3> vectors)
    /*
        static @Method Multiply
            Multiplies Vectors by their components.
            example:
            Vector3 v = new(a,b,c);
            Vector3 w = new(e,f,g);

            v.Multiply(w) = new (a*e, b*f, c*g);
            
    */
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
    /*
        static @Method Divide
            returns the quotient of two vectors by their components.
            example:
            Vector3 v = new(a,b,c);
            Vector3 w = new(e,f,g);

            v.Divide(w) = new (a/e, b/f, c/g);            
    */
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

    // Vector2 Conversions
    static public Vector3 ToVector3(Vector2 vector2, string combination)
    // Conversion from Vector2 to Vector4
    {
        Vector3 result = new Vector3(0,0,0);

        if(combination.Length != 3)
        {
            throw new InvalidCharacterException(combination);
        }

        result.x = combination[0] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };

        result.y = combination[1] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };

        result.z = combination[2] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };
        
        return result;
    }
    static public Vector4 ToVector4(Vector2 vector2, string combination)
    // Conversion from Vector2 to Vector4
    {
        Vector4 result = new Vector4(0,0,0,0);

        if(combination.Length != 4)
        {
            throw new InvalidCharacterException($"Your combination does NOT have exactly 4 characters.");
        }

        result.x = combination[0] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };

        result.y = combination[1] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };

        result.z = combination[2] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };

        result.w = combination[3] switch
        {
            'x' => vector2.x,
            'y' => vector2.y,
            _ => throw new InvalidVector2String("Vector4", combination),
        };
        
        return result;
    }

    // Vector3 Conversions
    static public Vector2 ToVector2(Vector3 vector3, string combination)
    {
        Vector2 result = new Vector2();

        if(combination.Length != 2)
        {
            throw new InvalidVector3String("Vector2", combination);
        }

        result.x = combination[0] switch
        {
            'x' => vector3.x,
            'y' => vector3.y,
            'z' => vector3.z,
            _ => throw new InvalidVector3String(combination)
        };

        result.y = combination[1] switch 
        {
            'x' => vector3.x,
            'y' => vector3.y,
            'z' => vector3.z,
            _ => throw new InvalidVector3String(combination)
        };

        return result;
    }

    static public Vector4 ToVector4(Vector3 vector3, string combination)
    {
        Vector4 result = new Vector4();

        return result;
    }

    // Vector4 Conversions









}

[System.Serializable]
public class InvalidCharacterException : System.Exception
{
    public InvalidCharacterException() { }
    public InvalidCharacterException(string message) : base(message) { }
    public InvalidCharacterException(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidCharacterException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

class InvalidVector2String : InvalidCharacterException
{   public InvalidVector2String(string vector, string combination) : base("To " + vector + "(Vector2, string) only allows the characters 'x' & 'y'. You provided the string " + combination) { }
    public InvalidVector2String(string combination) : base($"Your string {combination} does NOT have exactly 2 characters.") { }
    public InvalidVector2String(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidVector2String(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

class InvalidVector3String : InvalidCharacterException
{   public InvalidVector3String(string vector, string combination) : base("To " + vector + "(Vector3, string) only allows the characters 'x', 'y' & 'z'. You provided the string " + combination) { }
    public InvalidVector3String(string combination) : base($"Your string {combination} does NOT have exactly 3 characters.") { }
    public InvalidVector3String(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidVector3String(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

class InvalidVector4String : InvalidCharacterException
{   public InvalidVector4String(string vector, string combination) : base("To " + vector + "(Vector4, string) only allows the characters 'w', 'x', 'y' & 'z'. You provided the string " + combination) {}
    public InvalidVector4String(string combination) : base($"Your string {combination} does NOT have exactly 4 characters.") { }
    public InvalidVector4String(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidVector4String(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

