using UnityEngine;

public class MovePlatform : MonoBehaviour
{

	public GameObject NewTrailSection;
	private bool isNewPlatform = false;


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
		transform.position += new Vector3(0, 0, -20 * Time.deltaTime);

		//Create new platform
		if (transform.position.z <= -100 && !isNewPlatform)
		{
			Instantiate(NewTrailSection, new Vector3(0, 0, transform.position.z + 200), Quaternion.identity);
			isNewPlatform = true;
		}

		//Destroy Platform
		if (transform.position.z <= -300)
		{
			Destroy(gameObject); 
		}

		//Set status
		if (transform.position.z > -100)
		{
			isNewPlatform = false;
		}

	}
}


