using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public playerHealth pHealth;
    public float damage;
	public AudioClip ouch;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("HealthDown"))
		{
			//lowers player health
			pHealth.health -= damage;
			//damage taken sound
			AudioSource.PlayClipAtPoint(ouch, transform.position);
		}
	}
}
