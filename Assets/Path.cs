using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> points = new();

    public void GetNextPoint()
    {

    }

    public Transform GetClosestPoint(Vector3 position)
    {
	    return points[0];
    }

    void OnDrawGizmos()
    {
	    Gizmos.color = Color.red;

	    for (int i = 0; i < points.Count - 1; i++)
	    {
		    Gizmos.DrawLine(points[i].position, points[i + 1].position);
	    }

	    Gizmos.DrawLine(points[^1].position, points [0].position);
    }
}