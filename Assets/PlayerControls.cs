using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public Rigidbody2D rb;

    private float mx;
    
    [Header("Paddle Properties")]
    public float paddleSpeed = 10f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        
    }

    void FixedUpdate() {
        mx = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, mx * paddleSpeed);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }
}
