using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
	public playerHealth pHealth;
	public float healthUp;
	public AudioClip heal;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("HealthUp"))
		{
			if(pHealth.health < 100)
			{
				//Increase player health
				pHealth.health += healthUp;
				//heal sound
				AudioSource.PlayClipAtPoint(heal, transform.position);
			}
		}
	}
}
