using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehave : MonoBehaviour {

	public float mSpeed = 1f;
	public float lifeSpan = 5f;
	public float timeAlive = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeAlive += Time.deltaTime;
		if (timeAlive >= lifeSpan) {
			Destroy (this.gameObject);
		}
	}

	void FixedUpdate() {
		this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x + (mSpeed * Time.fixedDeltaTime) , this.gameObject.transform.position.y, 0);
	}
}
