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
     void Start()
    {
        // Example 1: Reset to default values
        transform.Reset(); // Position: (0, 0, 0), Rotation: (0, 0, 0), Scale: (1, 1, 1)

        // Example 2: Only provide rotation
        transform.Reset(rotation: Quaternion.Euler(45, 90, 0)); // Position: (0, 0, 0), Rotation: (45, 90, 0), Scale: (1, 1, 1)

        // Example 3: Provide position and scale, skip rotation
        transform.Reset(position: new Vector3(5, 5, 5), scale: new Vector3(2, 2, 2)); // Position: (5, 5, 5), Rotation: (0, 0, 0), Scale: (2, 2, 2)
    }
}
```
