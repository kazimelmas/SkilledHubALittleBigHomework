using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damageAmount = 20;
    public float attackRange = 2f;
    public LayerMask enemyLayer;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    void Attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, attackRange, enemyLayer))
        {
            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if(enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageAmount);
            }
        }
    }
}
