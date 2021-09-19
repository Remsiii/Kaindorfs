using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    public float MovementSpeed = 1;
    private Rigidbody2D _rigibody;

    public float JumpForce = 1;
    public GameObject spieler;
    private Animator anim;

    private float movement = 0f;
    private float jump = 0f;

    void Start()
    {
        _rigibody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // gehen
        movement = Input.GetAxis("Horizontal");
        jump = Input.GetAxis("Jump");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //drehen, links rechts gehen
        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        //jumnpen
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigibody.velocity.y) < 0.001f)
        {
            _rigibody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        //Debug.Log(Mathf.Abs(_rigibody.velocity.y));
        if (Input.GetAxis("Jump") == 1)
        {
            anim.SetBool("Jumping", true);
        }
        else if(Mathf.Abs(_rigibody.velocity.y) < 0.001f)
        {
            anim.SetBool("Jumping", false);
        }
      
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (movement > 0f)
        {
            anim.SetBool("Running", true);
        }
        else if (movement < 0f)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}
