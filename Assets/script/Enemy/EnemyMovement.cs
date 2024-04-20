using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class EnemyMovement : MonoBehaviour
{
    public Collider2D trig;
    public Transform target;
    public float stoppigDistance=0.1f;
    public float speed = 0.5f;
    private Rigidbody2D rb;
    public Vector2 moveDIr;

    public PLTarget tr;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        MoveChar(moveDIr);
    }

    private void MoveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

    }

    void Update()
    {

        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);



        Vector3 direction = /*target.position*/  tr.tra.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        moveDIr = direction;

        if (tr.tra.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }


}
