using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Verzameling van Waypoints
//biedt bepaalde toegang
public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;
    public Waypoint GetPathStart()
    {
        return _waypoints[0];
    }

    public Waypoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }

    public Waypoint GetNextWaypoint(Waypoint CurrentWaypoint)
    {
        for (int i = 0; i < _waypoints.Length; i++)
        {
            if (_waypoints[i] == CurrentWaypoint)
            {
                return _waypoints[i + 1];
            }
        }
        return null;
    }
}
