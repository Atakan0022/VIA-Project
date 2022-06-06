using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcNew : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    public Rigidbody2D rigidbody2d;
    float timer;
    float direction = 1;
    public void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }


    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;

        }
    }
    public void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction; ;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction; ;
        }
        rigidbody2d.MovePosition(position);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        haraket3 player = other.gameObject.GetComponent<haraket3>();
        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

}
