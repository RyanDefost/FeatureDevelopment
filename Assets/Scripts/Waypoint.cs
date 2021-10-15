using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Houdt een positie bij om naartoe te gaan.
public class Waypoint : MonoBehaviour
{
    public Vector3 Getposition()
    {
        return transform.position;
    }
}
