using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Beweegt langs een Path
public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThresholds;
    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }
    private void Update()
    {
        //transform.LookAt(_currentWaypoint.Getposition());
        Vector3 waypointPosition = _currentWaypoint.Getposition();
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        float distanceToWaypoint = Vector3.Distance(transform.position, new Vector3(waypointPosition.x, transform.position.y, waypointPosition.z));
        if (distanceToWaypoint <= _arrivalThresholds)
        {
            if(_currentWaypoint == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.Getposition() + new Vector3(0, transform.position.y ,0));
            }
        }
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }

    private void PathComplete()
    {
        _speed = 0;

        FindObjectOfType<PlayerHealthComponent>().TakenDamage(1);

        Destroy(gameObject);
    }
}
