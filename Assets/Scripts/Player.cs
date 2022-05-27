using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float speed;

    private void Start() {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rigidBody.velocity.y);
    }
}
