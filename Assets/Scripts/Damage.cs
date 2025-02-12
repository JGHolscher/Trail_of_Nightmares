using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public playerHealth pHealth;
    public float damage;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("HealthDown"))
		{
			pHealth.health -= damage;
		}
	}
}
