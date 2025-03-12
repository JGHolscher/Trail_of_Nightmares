using UnityEngine;

public class MovePlatform : MonoBehaviour
{

	public GameObject NewTrailSection;
	public GameObject NewTrailSection2;
	public GameObject NewTrailSection3;

	private bool isNewPlatform = false;

	// Update is called once per frame
	void Update()
	{
		
		transform.position += new Vector3(0, 0, -20 * Time.deltaTime);

		//Create new platform
		if (transform.position.z <= -100 && !isNewPlatform)
		{
			//Instantiate(NewTrailSection, new Vector3(0, 0, transform.position.z + 200), Quaternion.identity);
			
			GameObject[] platforms = { NewTrailSection, NewTrailSection2, NewTrailSection3 };
			int randomIndex = Random.Range(0, platforms.Length); // Get a random index
			
			Instantiate(platforms[randomIndex], new Vector3(0, 0, transform.position.z + 200), Quaternion.identity);

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


