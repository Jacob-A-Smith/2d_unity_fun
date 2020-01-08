using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour {

	public float mSpeed = 1f;
	public Rigidbody2D rb;
	public GameObject Spell_1;
	public GameObject Spell_2;
	public GameObject Spell_3;
	public GameObject Spell_4;

	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float xDelta = this.gameObject.transform.position.x + (mSpeed * Input.GetAxis("Horizontal") * Time.fixedDeltaTime);
		float yDelta = this.gameObject.transform.position.y + (mSpeed * Input.GetAxis("Vertical") * Time.fixedDeltaTime);
		/*
		RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, Vector2.up);
		if (hit.collider != null) {
			float distance = Mathf.Abs(hit.point.y - this.gameObject.transform.position.y);
			if (yDelta >= distance){
				Debug.Log("Too far up");
				yDelta = this.gameObject.transform.position.y;
			}
		}*/
		this.gameObject.transform.position = new Vector3(xDelta, yDelta, this.gameObject.transform.position.z);
	}




	public void setTarget (GameObject newTarget) {
		this.target = newTarget;
	}

	void OnGUI() {
	//	Debug.DrawRay(this.gameObject.transform.position, (this.gameObject.transform.position - target.transform.transform.position)*10, Color.red);
		// RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, this.gameObject.transform.position - target.transform.transform.position);
		/* if (hit.collider == target.GetComponent<Collider2D>()) {
			Debug.Log("CAN SEE");
		}*/

		/* RaycastHit2D hit = Physics2D.Raycast(target.transform.transform.position, target.transform.transform.position - this.gameObject.transform.position);
		Debug.DrawRay(target.transform.transform.position,  (target.transform.transform.position - this.gameObject.transform.position)*10f,Color.red);
		if (hit.collider != null) {
			Debug.Log(hit.collider.name);
		}*/

		RaycastHit2D[] hitResults = Physics2D.RaycastAll(this.gameObject.transform.position, target.transform.transform.position - this.gameObject.transform.position);
		//	Debug.DrawRay(this.gameObject.transform.position, (target.transform.transform.position - this.gameObject.transform.position), Color.red, 20, false);
		//if(hitResults.Length == 2) {
			// Debug.Log("LoS");
		// }
		//Debug.Log(hitResults[1].collider.name + "   " + hitResults.Length);
		// for (int i = 0; i < hitResults.Length; ++i) {
			// Debug.Log(hitResults[i].collider.name);
		// }
		if(hitResults[1].collider != target.GetComponent<Collider2D>()) {
			return;
		}

		if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Alpha1.ToString())))
		{
			Debug.Log("1 key is pressed.");
			 //lastSpell = Instantiate (Spell_1, new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
			 target.GetComponent<SpellCast>().CastSpell(Spell_1, this.gameObject.transform);
		}
		else if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Alpha2.ToString())))
		{
			Debug.Log("2 key is pressed.");
			  // lastSpell = Instantiate (Spell_2, new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
				target.GetComponent<SpellCast>().CastSpell(Spell_2, this.gameObject.transform);
		}
		else if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Alpha3.ToString())))
		{
			Debug.Log("3 key is pressed.");
			  // lastSpell = Instantiate (Spell_3, new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
				target.GetComponent<SpellCast>().CastSpell(Spell_3, this.gameObject.transform);
		}
		else if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Alpha4.ToString())))
		{
			Debug.Log("4 key is pressed.");
			  // lastSpell = Instantiate (Spell_4, new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
				target.GetComponent<SpellCast>().CastSpell(Spell_4, this.gameObject.transform);
		}
	}
}
