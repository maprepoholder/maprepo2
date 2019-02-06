using UnityEngine;

public static class ExtensionsTransform
{
    public static Vector3 clampVectorX(this Vector3 vec, float angleMin = 20, float angleMax = 90)
    {
        Vector3 v = new Vector3(Mathf.Clamp(vec.x, angleMin, angleMax), vec.y, vec.y);
        return v;
    }
    public static Vector3 clampVectorY(this Vector3 vec, float angleMin = 20, float angleMax = 89)
    {
        Vector3 v = new Vector3(vec.x, Mathf.Clamp(vec.y, angleMin, angleMax), vec.z);
        return v;
    }

    public static Vector3 clampVectorZ(this Vector3 vec, float angleMin = 20, float angleMax = 89)
    {
        Vector3 v = new Vector3(vec.x, vec.y, Mathf.Clamp(vec.z, angleMin, angleMax));
        return v;
    }
}