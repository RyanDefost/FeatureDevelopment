using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// en op vijand schieten.

[RequireComponent(typeof(EnemyInRangeChecker))]
public class Tower : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 5;
    [SerializeField] private float _shootCooldown = 0.5f;
    [SerializeField] private Transform _turret;

    private EnemyInRangeChecker _enemyInRangeChecker;
    private float _nextShootTime = 0;

    private void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();
    
    }
    private void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy != null)
        {
            print(enemy.name);

            _turret.LookAt(enemy.transform);
            if (CanShoot())
            {
                enemy.GetHealthComponent().TakenDamage(_damageAmount);
                _nextShootTime = Time.time + _shootCooldown;
            }        
        }
    }
    

    private bool CanShoot()
    {
        return _nextShootTime >= Time.time;
    }
}
