using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Movement : MonoBehaviour {

    
    public float speed = 6f;
    public float jumpPower = 6f;
    public bool grounded;
    public int points;

    
    private bool jumping = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    // Use this for initialization
    void Start () {
        points = 0;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("VerticalSpeed", Mathf.Abs(rb2d.velocity.y));

        float horizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded == true)
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);

        }
        
        if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        Debug.Log(points);
    }

     

}
