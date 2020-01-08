using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {
	public float maxHealth = 500;
	public float healthPoints = 500;
	public GameObject HealthBar;
	public GameObject DeathAnimation;
	public GameObject myPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (healthPoints <= 0) {
			GameObject tombstone = Instantiate(DeathAnimation, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 1), Quaternion.identity);
			tombstone.transform.parent = this.gameObject.transform.parent;
			Destroy(this.gameObject);
		}
	}

	public void DealDamage(float amount) {
		healthPoints -= amount;
		HealthBar.transform.localScale = new Vector3(healthPoints/maxHealth ,1, 1);
	}
}
