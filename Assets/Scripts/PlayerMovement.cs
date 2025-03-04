using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public Animator playerAnimation;
	public Rigidbody playerRigid;
	public float side_speed;
	public float jumpForce;
	public bool running;
	public Transform playerTrans;

	void Update()
	{
		playerRigid.position = new Vector3(playerRigid.position.x, playerRigid.position.y, -176);

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

		//Jump - tested works just not on character why???
		if (Input.GetKey(KeyCode.Space))//GetButtonDown("Jump"))
		{
			playerRigid.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
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
