using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public Animator playerAnimation;
	public Rigidbody playerRigid;
	public float run_speed, side_speed, jump_speed;
	public float jumpForce;
	public bool running;
	public Transform playerTrans;

	void Update()
	{
	
		playerAnimation.SetTrigger("Run");
			
		running = true;
		

		//To move character left and right
		if (Input.GetKey(KeyCode.A))
		{
			playerRigid.MovePosition(playerRigid.position - transform.right * side_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			playerRigid.MovePosition(playerRigid.position + transform.right * side_speed * Time.deltaTime);
		}

		//Jump
		//playerRigid.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

		//To move character forward - not needed
		/*
		if (Input.GetKey(KeyCode.W))
		{
			playerRigid.MovePosition(playerRigid.position + transform.forward * run_speed * Time.deltaTime);
		}
		*/
	}
}
