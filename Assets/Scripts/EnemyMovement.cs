using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }
    
    void Update()
    {
        myRigidbody.velocity = new Vector2 (moveSpeed, 0f);
    }
    
    /*void onTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }*/

   void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D"+ col.gameObject.name);
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2 (-(Mathf.Sign(myRigidbody.velocity.x)), 1f);
    }
}
