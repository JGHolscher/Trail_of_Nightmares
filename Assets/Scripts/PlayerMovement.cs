using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public Animator playerAnimation;
	public Rigidbody playerRigid;
	public float run_speed, side_speed;
	public bool running;
	public Transform playerTrans;

	void Update()
	{
		//Start Running Animation when W pressed
		if (Input.GetKeyDown(KeyCode.W))
		{
			playerAnimation.SetTrigger("Run");
			playerAnimation.ResetTrigger("Idle");
			running = true;
		}
		//stop running when s is pressed
		if (Input.GetKeyDown(KeyCode.S))
		{
			playerAnimation.SetTrigger("Run");
			playerAnimation.ResetTrigger("Idle");
			running = false;
		}

		//To move character left and right
		if (Input.GetKey(KeyCode.A))
		{
			playerRigid.MovePosition(playerRigid.position - transform.right * side_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			playerRigid.MovePosition(playerRigid.position + transform.right * side_speed * Time.deltaTime);
		}

		//To move character forward - not needed
		/*
		if (Input.GetKey(KeyCode.W))
		{
			playerRigid.MovePosition(playerRigid.position + transform.forward * run_speed * Time.deltaTime);
		}
		*/
		}
}
