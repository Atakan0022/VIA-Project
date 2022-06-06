using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraket3 : MonoBehaviour
{
    private bool facingRight; 
    Rigidbody2D rigidbody2d;
    public float horizontal;
    public float vertical;

    public float speed = 3.0f;
    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    public int health { get { return currentHealth; } }
    int currentHealth;
    bool isInvincible;
    float invincibleTimer;


    void Start()
    {
        facingRight = true;
        rigidbody2d = GetComponent<Rigidbody2D>();
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
        Vector2 position = transform.position;
        position.x = position.x + 11.0f * horizontal * Time.deltaTime;
        position.y = position.y + 11.0f * vertical * Time.deltaTime;
        transform.position = position;
        rigidbody2d.MovePosition(position);



        Flip(horizontal);
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
        Debug.Log(currentHealth + "/" + maxHealth);

    }

    private void Flip(float horizontal)
    {


        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
    
   /* void OnCollisionEnter2D(Collision2D d)
    {
        diyalogNpc character = d.collider.GetComponent<diyalogNpc>();
        if (character != null)
        {
            character.DisplayDialog();
        }
    } */

}