using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakenDamage(1);
        }
    }

    protected override void HandelTakeDamage()
    {
        base.HandelTakeDamage();
        //Update je healthBar
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}
