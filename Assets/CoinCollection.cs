using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int Coin;
	public AudioClip coin;

	public TextMeshProUGUI coinText;

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Coin")
		{
			//Scoring count
			Coin += 20;

			//Score Display
			coinText.text = "Score: " + Coin.ToString();
			//Destroy
			Destroy(other.gameObject);
			//Collection Audio
			AudioSource.PlayClipAtPoint(coin, transform.position);
		}
	}
}
