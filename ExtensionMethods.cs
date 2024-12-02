using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
    #region ResetTransform
    /// <summary>
    /// Resets the position, rotation, and scale of a Transform based on optional parameters.
    /// If a parameter is not provided, it defaults to specific values:
    /// - Position: Vector3.zero (0, 0, 0)
    /// - Rotation: Quaternion.identity (no rotation)
    /// - Scale: Vector3.one (1, 1, 1)
    /// </summary>
    /// <param name="tran">The Transform to reset.</param>
    /// <param name="position">Optional new position. Defaults to Vector3.zero if null.</param>
    /// <param name="rotation">Optional new rotation. Defaults to Quaternion.identity if null.</param>
    /// <param name="scale">Optional new scale. Defaults to Vector3.one if null.</param>
    public static void ResetTransform(
        this Transform tran, 
        Vector3? position = null, 
        Quaternion? rotation = null, 
        Vector3? scale = null)
    {
        // If position is provided, use it; otherwise, fallback to Vector3.zero.
        tran.position = position ?? Vector3.zero;

        // If rotation is provided, use it; otherwise, fallback to Quaternion.identity (no rotation).
        tran.rotation = rotation ?? Quaternion.identity;

        // If scale is provided, use it; otherwise, fallback to Vector3.one (default scale).
        tran.localScale = scale ?? Vector3.one;
    }
    #endregion

    #region ResetVectorComponents
    /// <summary>
    /// Modifies specific components (x, y, z) of a Vector3.
    /// Any component not provided will retain its current value.
    /// The provided values are used to modify the Vector3, and the unchanged components remain the same.
    /// </summary>
    /// <param name="vector">The original Vector3 to modify.</param>
    /// <param name="x">Optional new x value. If null, the current x value is kept.</param>
    /// <param name="y">Optional new y value. If null, the current y value is kept.</param>
    /// <param name="z">Optional new z value. If null, the current z value is kept.</param>
    /// <returns>A new Vector3 with the modified components.</returns>
    public static Vector3 ResetVectorComponents(
        this Vector3 vector, 
        float? x = null, 
        float? y = null, 
        float? z = null)
    {
        // Use the null-coalescing operator to assign new values or retain the current ones.
        // If x is provided, use it; otherwise, keep the current x value.
        x ??= vector.x;

        // If y is provided, use it; otherwise, keep the current y value.
        y ??= vector.y;

        // If z is provided, use it; otherwise, keep the current z value.
        z ??= vector.z;

        // Return a new Vector3 with the updated components.
        return new Vector3(x.Value, y.Value, z.Value);
    }
    #endregion

    #region GetOrAddCompoment
    /// <summary>
    /// Retrieves a component of type <typeparamref name="T"/> from the specified <see cref="GameObject"/>.
    /// If the component does not exist, it adds and returns a new one.
    /// </summary>
    /// <typeparam name="T">The type of the component to retrieve or add.</typeparam>
    /// <param name="gameObject">The GameObject to search for the component.</param>
    /// <returns>The existing or newly added component of type <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the provided GameObject is null.</exception>
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (gameObject == null) 
            throw new ArgumentNullException(nameof(gameObject), "GameObject cannot be null.");

        return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
    }
    #endregion
}