using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //private Animator anim;
    public float attackTime;
    public float startTimeAttack;
    public Transform attackLocation;
    public float attackRange;
    public LayerMask Enemy;
    private float attacktekrar;
    float attackFunction()
    {
        return 1;
    }
    private void Start()
    {
       // anim = GetComponent<Animator>();
        StartCoroutine(AttackLoop());
    }

    IEnumerator AttackLoop()
    {
        do
        {
            if (attacktekrar > 0)
            {
               // anim.SetBool("Attack", true);
                Collider2D[] damage = Physics2D.OverlapCircleAll(attackLocation.position, attackRange, Enemy);

                for (int i = 0; i < damage.Length; i++)
                {
                    Destroy(damage[i].gameObject);
                }

                attackTime = startTimeAttack;

                attackTime -= Time.deltaTime;
                Debug.Log("Attack Yapýyor");
            //  if ( attacktekrar > 0 )
            //      anim.SetBool ("Attack" , true);
            //  else
            //      anim.SetBool("Attack" ,false ); 

            }
            yield return new WaitForSeconds(attacktekrar);
        } while (attacktekrar > 0);
    }
    
    void Update()
    {
        attacktekrar = attackFunction() *2 ; //Bu, "attack" deðiþkenini  2 ye  ayarlayacak   
    }
}
