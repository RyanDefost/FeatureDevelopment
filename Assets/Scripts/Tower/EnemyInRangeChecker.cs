using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInRangeChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layer;

    private Enemy Enemy;

    public Enemy GetFirstEnemyInRange()
    {
        Collider[] clos = Physics.OverlapSphere(transform.position, _radius, _layer);
        print(clos.Length);
        if (clos.Length <= 0)
        {
            return null;
        }
        return clos[0].GetComponent<Enemy>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
