using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehaviour : MonoBehaviour {

	public float mSpeed = 1f;
	public float lifeSpan = 5f;
	public float damage = 25f;
	//public float timeAlive = 0f;
	public bool move = false;

	//public GameObject target;
	//public Transform target;

	// Use this for initialization
	void Start () {
		//target = null;
	}
	
	// Update is called once per frame
	void Update () {
		/* timeAlive += Time.deltaTime;
		if (timeAlive >= lifeSpan) {
			Destroy (this.gameObject);
		}*/
	}

	void FixedUpdate() {
		// this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x + (mSpeed * Time.fixedDeltaTime) , this.gameObject.transform.position.y, 0);
		// float _x = this.gameObject.transform.position.x +  (mSpeed * Time.fixedDeltaTime);
		if (move) {
			//this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target.position, mSpeed * Time.fixedDeltaTime);
			this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.gameObject.transform.parent.position, mSpeed * Time.fixedDeltaTime);
			if (this.gameObject.transform.position.Equals(this.gameObject.transform.parent.position)) {
				this.gameObject.transform.parent.gameObject.GetComponent<HealthManager>().DealDamage(damage);
				Destroy (this.gameObject);
			}
		}
	}
/*
	public void cast(GameObject _target) {
		this.target = _target;
		move=true;
	}*/
}