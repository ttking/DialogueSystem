using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D playerRb;
    [SerializeField]
    private float speed = 10;

	// Use this for initialization
	void Start () {
        playerRb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
	}

    private void HandleMovement(float horizontal)
    {
        playerRb.velocity = new Vector2(horizontal * speed, playerRb.velocity.y);
    }
}
