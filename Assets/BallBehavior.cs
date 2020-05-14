using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
    public Rigidbody2D rb;

    [Header("Ball Properties")]
    public float ballSpeed = 20f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Invoke("startBall", 2);
    }

    void Update() {

    }

    void startBall() {
        if(Random.Range(0, 2) < 1) {
            rb.AddForce(new Vector2(ballSpeed, 15));
        } else {
            rb.AddForce(new Vector2(-ballSpeed, 15));
        }
    }

    void resetGame() {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("startBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if(coll.collider.CompareTag("Player")) {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3));
        }
        if(coll.collider.CompareTag("SideWall")) {
            resetGame();
        }
    }
}
