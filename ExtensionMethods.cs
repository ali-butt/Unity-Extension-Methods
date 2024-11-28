using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
    public static void Reset(this Transform tran, 
                         Vector3? position = null, 
                         Quaternion? rotation = null, 
                         Vector3? scale = null)
    {
        // Use provided values or fallback to defaults
        tran.position = position ?? Vector3.zero;
        tran.rotation = rotation ?? Quaternion.identity;
        tran.localScale = scale ?? Vector3.one;
    }
}