# Unity-Extension-Methods

A collection of useful extension methods for Unity development. I will keep adding more extensions methods, to simplify your Unity development workflows.

# Unity ExtensionMethods

This repository contains an extension method for Unity's `Transform` class, allowing you to easily reset position, rotation, and scale.

## Features

- Resets position, rotation, and scale of a `Transform` to custom or default values.
- Simplifies resetting of objects during runtime.

## How to Use

1. **Add the Script to Your Project**

   - Download or clone this repository.
   - Add the `ExtensionMethods.cs` script to your Unity project, ideally in a folder called `Scripts` or `Extensions`.

2. **Usage Example**
   You can call the `Reset` method on any `Transform` object. It allows you to reset the position, rotation, and scale to either custom values or defaults.

### Example:

```csharp
using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 targetVector;

    void Start()
    {
        // -------------------------------
        // 1. Example: Reset the entire transform to default values
        // Resets position to (0,0,0), rotation to (0,0,0), and scale to (1,1,1)
        targetTransform.ResetTransform();
        Debug.Log("Reset Transform to default: " + targetTransform.position + ", " + targetTransform.rotation + ", " + targetTransform.localScale);

        // -------------------------------
        // 2. Example: Reset only the position of the transform
        // Position: (1, 2, 3), keeps current rotation and scale
        targetTransform.ResetTransform(position: new Vector3(1f, 2f, 3f));
        Debug.Log("Reset position: " + targetTransform.position);

        // -------------------------------
        // 3. Example: Reset only the rotation of the transform
        // Rotation: 90 degrees on the Y-axis, keeps current position and scale
        targetTransform.ResetTransform(rotation: Quaternion.Euler(0f, 90f, 0f));
        Debug.Log("Reset rotation: " + targetTransform.rotation);

        // -------------------------------
        // 4. Example: Reset only the scale of the transform
        // Scale: (2, 2, 2), keeps current position and rotation
        targetTransform.ResetTransform(scale: new Vector3(2f, 2f, 2f));
        Debug.Log("Reset scale: " + targetTransform.localScale);

        // -------------------------------
        // 5. Example: Reset all transform components (position, rotation, scale)
        // Position: (5, 5, 5), Rotation: 45 degrees on Y-axis, Scale: (3, 3, 3)
        targetTransform.ResetTransform(position: new Vector3(5f, 5f, 5f), 
                                        rotation: Quaternion.Euler(0f, 45f, 0f), 
                                        scale: new Vector3(3f, 3f, 3f));
        Debug.Log("Reset all components: " + targetTransform.position + ", " + targetTransform.rotation + ", " + targetTransform.localScale);

        // -------------------------------
        // 6. Example: Reset the Vector3 components, change only the x component
        // Changes only x to 10, keeps the original y and z values
        targetVector = targetVector.ResetVectorComponents(x: 10f);
        Debug.Log("Reset only x component: " + targetVector);

        // -------------------------------
        // 7. Example: Reset the Vector3 components, change only the y component
        // Changes only y to 20, keeps the original x and z values
        targetVector = targetVector.ResetVectorComponents(y: 20f);
        Debug.Log("Reset only y component: " + targetVector);

        // -------------------------------
        // 8. Example: Reset the Vector3 components, change only the z component
        // Changes only z to 30, keeps the original x and y values
        targetVector = targetVector.ResetVectorComponents(z: 30f);
        Debug.Log("Reset only z component: " + targetVector);

        // -------------------------------
        // 9. Example: Reset the Vector3 components, change x and y, keep z unchanged
        // Changes x to 5 and y to 10, keeps the original z value
        targetVector = targetVector.ResetVectorComponents(x: 5f, y: 10f);
        Debug.Log("Reset x and y components: " + targetVector);

        // -------------------------------
        // 10. Example: Reset the Vector3 components, change x and z, keep y unchanged
        // Changes x to 50 and z to 60, keeps the original y value
        targetVector = targetVector.ResetVectorComponents(x: 50f, z: 60f);
        Debug.Log("Reset x and z components: " + targetVector);

        // -------------------------------
        // 11. Example: Reset the Vector3 components, change all three components
        // Changes all components to new values: x = 100, y = 200, z = 300
        targetVector = targetVector.ResetVectorComponents(x: 100f, y: 200f, z: 300f);
        Debug.Log("Reset all components: " + targetVector);
    }
}
```
