using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float turnSpeed;

    public Vector2 moveDirection;
    public Vector2 mousePos;
    public Camera Cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Move();

        //Mouse position
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void Inputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        /*if (moveDirection != Vector2.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation , Quaternion.LookRotation( Vector3.forward,moveDirection), Time.fixedDeltaTime * turnSpeed);
        }*/
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);


    }
}
