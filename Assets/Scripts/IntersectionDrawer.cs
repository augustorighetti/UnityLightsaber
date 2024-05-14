using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionDrawer : MonoBehaviour
{
    public GameObject prefab;

    public void DrawIntersection(Vector3 v3, Quaternion q)
    {
        Instantiate(prefab,v3,q);
    }
    
}
