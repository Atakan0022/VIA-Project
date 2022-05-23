using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraket4 : MonoBehaviour
{
    private float speed ;
    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    private Animator anim;

    public int health { get { return currentHealth; } }
    int currentHealth;
    bool isInvincible;
    float invincibleTimer;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    private bool facingRight;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        speed = 5;
    }

   
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }

    void FixedUpdate()
    {
            Vector2 position = rigidbody2d.position;
            position.x = position.x + speed  * horizontal * Time.deltaTime;
            position.y = position.y + speed  * vertical * Time.deltaTime;

            rigidbody2d.MovePosition(position);
        if (speed > 0)
            anim.SetFloat("Run", 1);
        else
            anim.SetFloat("Run", 0);
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        
    }
    private void Flip (float horizontal)
    {


        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
