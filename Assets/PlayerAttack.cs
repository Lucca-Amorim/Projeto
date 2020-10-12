using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour{

    public Transform attackPoint;
    public float attackRange;
    public LayerMask enemyLayers;
    public Animator animator;

    private void Start(){
        animator = this.gameObject.GetComponent<Animator>();
        
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            Atacar();
        }

    }
    void Atacar(){
        //animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies){
            Debug.Log("hit" + enemy.name);
        }
    }

    void OnDrawGizmosSelected(){
        if(attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
