using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField] int maxHealth = 100;
	[SerializeField] int minHealth = 0;
	[SerializeField] int currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Damage(int val) {
		// reduce currentHealth
		currentHealth -= val;

		// make sure currentHealth is not less than minHealth
		if (currentHealth < minHealth)		
			currentHealth = minHealth;

	}

	public void Heal(int val) {
		// reduce currentHealth
		currentHealth += val;
		
		// make sure currentHealth is not bigger than maxHealth
		if (currentHealth > maxHealth)		
			currentHealth = maxHealth;
	}

	public int getCurrentHealth()
	{
		return currentHealth;
	}

	public bool isDead()
	{
		if(currentHealth == 0)
			return true;
		return false;
	}
}
