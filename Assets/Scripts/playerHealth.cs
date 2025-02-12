using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

	public float health;
	public float maxiHealth;
    public Image healthBar;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        maxiHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxiHealth, 0, 1);
    }
}
