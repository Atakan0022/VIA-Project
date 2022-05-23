using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenememNpc : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Transform Player;
    public float moveSpeed = 5f;
    private Vector2 movement;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();     
    }
    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Deg2Rad;
        rigidbody2d.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rigidbody2d.MovePosition((Vector2)transform.position + (direction*moveSpeed * Time.deltaTime));
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        haraket4 player = other.gameObject.GetComponent<haraket4>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
   
}

