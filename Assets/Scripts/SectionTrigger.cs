using UnityEngine;

public class SectionTrigger : MonoBehaviour
{

    public GameObject NewTrailSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
			Instantiate(NewTrailSection, new Vector3(0, 0, 152), Quaternion.identity);
		}
    }
}
