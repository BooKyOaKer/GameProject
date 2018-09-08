using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator myAnim;


    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    public bool isAttack;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetBool("Attack", isAttack);

        if (timeBtwAttack <= 0)
        {
            isAttack = false;
            if (Input.GetKey(KeyCode.F))
            {
                isAttack = true;
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    //enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                timeBtwAttack = startTimeBtwAttack;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);

    }
}
