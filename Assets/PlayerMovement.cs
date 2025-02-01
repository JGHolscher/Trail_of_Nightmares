using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

	public Animator playerAnimation;
    public Rigidbody playerRigid;
    public float rn_speed;
	public float s_speed;
    public float jumpSpeed;
    public bool running;
    public Transform playerTrans;

	//left and right
	public float horizontalSpeed = 3f;

	private void FixedUpdate()
	{
		float horizontalMovement = 0f;

		Vector3 currentVelocity = playerRigid.linearVelocity;

		Vector3 velocity = playerRigid.linearVelocity;

		if (Keyboard.current.aKey.isPressed)  // 'A' for left
		{
			horizontalMovement = -horizontalSpeed;
		}
		else if (Keyboard.current.dKey.isPressed) // 'D' for right
		{
			horizontalMovement = horizontalSpeed;
		}

		playerRigid.linearVelocity = new Vector3(horizontalMovement, currentVelocity.y);
	}

	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		/*if (Input.GetKeyDown(KeyCode.W))
		{
            playerAnimation.SetTrigger("Run");
            playerAnimation.ResetTrigger("Idle");
            running = true;
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			playerAnimation.ResetTrigger("Run");
			playerAnimation.SetTrigger("Idle");
			running = false;
		}*/
	}
}
