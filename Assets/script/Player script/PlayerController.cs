using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D  rb;
    public Vector3 moveDir;
    private bool facingRight=true;
    public int kol;
    private Animator anim;
    public float health;
    public Healthbar healthbar;
    public GameObject player;
    public int Kill = 0;
    public GameObject deathpanel;

    public EXPBar expbar;


    [SerializeField]
    float currentExperience;
    
    public float maxExperince;


    public int currentLevel=1;
    public void KillMan(int kills)
    {
        Kill++;
    }

    public void TakeDamage(float damage)
    {

        health -= damage;
        healthbar.SetHealth(health);
    }

    public void TakeEXP(float exp)
    {
        currentExperience += exp;
        if(currentExperience>maxExperince)
        {
            currentLevel++;
            currentExperience = 0;
            maxExperince =maxExperince+maxExperince/10;
        }
        
        expbar.SetEXP(currentExperience, maxExperince);
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthbar.maxHealth = health;
        healthbar.SetHealth(health);
        expbar.SetEXP(currentExperience,maxExperince);
    }

    // Update is called once per frame
    void Update()
    {
        InputManagment();
        anim = GetComponent<Animator>();
        if (health <= 0)
        {
            deathpanel.SetActive(true);
            Destroy(gameObject);
            Destroy(player);
        }

    }

    void FixedUpdate()
    {
        Move();





    }
    void InputManagment()
    {










        //float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");
        //moveDir = new Vector2(moveX, moveY).normalized;

        kol = 1;
        if (facingRight == false && moveDir.x > 0)
        {
            Flip();
            kol *= -1;
        }
        else if (facingRight == true && moveDir.x < 0)
        {
            Flip();
            kol *= -1;
        }

    }
    void Move()
    {
        moveDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.AddForce(moveDir * moveSpeed);




        //rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }

    void Flip()
    {
        
        facingRight = !facingRight;
        
        transform.Rotate(0f, 180f, 0f);
    }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }



    public enum States
    {
        run,
        idle

    }



}
