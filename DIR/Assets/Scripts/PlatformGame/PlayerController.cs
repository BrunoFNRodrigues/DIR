using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Rigidbody2D rb;
    float horizontal;
    public bool isGrounded;
    public float speed;
    public float jumpAmount = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionStay2D(){
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");   
        if (Input.GetKeyDown("space") && isGrounded){  
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpAmount);
            isGrounded = false;
        }
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontal *speed, GetComponent<Rigidbody2D> ().velocity.y);

    }
}
