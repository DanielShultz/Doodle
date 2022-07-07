using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static UnityEvent EventJump = new UnityEvent();

    private Rigidbody2D Rigidbody2D;
    public float StreightJump;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        EventJump.AddListener(PlayerJump);
    }

    void FixedUpdate()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = Input.acceleration.x > 0;

        Rigidbody2D.velocity = new Vector2(Input.acceleration.x * 15f, Rigidbody2D.velocity.y);

        if (Mathf.Abs(transform.position.x) > 3f)
        {
            transform.position = new Vector3(Mathf.Sign(transform.position.x)*-3f, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(0);
        }
    }

    void PlayerJump()
    {
        Rigidbody2D.velocity = Vector2.up * StreightJump;
    }
}
