using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBotBehavior : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        
    }

    void FixedUpdate() {
        GameObject ball = GameObject.Find("Ball");
        Vector3 pos = transform.position;
        pos.y = ball.transform.position.y;
        transform.position = pos;
    }
}
