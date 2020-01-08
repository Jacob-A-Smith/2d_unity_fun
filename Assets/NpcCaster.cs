using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCaster : MonoBehaviour {

	public GameObject spell;
	public GameObject target;

	public float castTime = 1.5f;
	float castTimer;

	// Use this for initialization
	void Start () {
		castTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			castTimer += Time.deltaTime;
			if (castTimer >= castTime) {
				//RaycastHit2D[] hitResults = Physics2D.RaycastAll(target.transform.transform.position, this.gameObject.transform.position - target.transform.transform.position);
					RaycastHit2D[] hitResults = Physics2D.RaycastAll(this.gameObject.transform.position, target.transform.transform.position - this.gameObject.transform.position);
				if (hitResults[1].collider == target.GetComponent<Collider2D>()) {
					target.GetComponent<SpellCast>().CastSpell(spell, this.gameObject.transform);
				}
				
				castTimer = 0f;
			}
		}
	}
}
