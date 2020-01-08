using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public float runSpeed = 40f;
	public GameObject Spell_1;
	public GameObject Spell_2;
	public GameObject Spell_3;
	public GameObject Spell_4;

	public GameObject target;
	// public GameObject lastSpell;

	float horizontalMove = 0f;
	bool jump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxisRaw ("Horizontal") * runSpeed;
		if (Input.GetButtonDown ("Jump")) {
			jump = true;
		}
		// if (lastSpell != null) {
			// lastSpell.GetComponent<SpellBehaviour>().target = this.target.gameObject.transform;
		//	lastSpell = null;
		// }
	}

	void FixedUpdate () {
		controller.Move (horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

	public void setTarget (GameObject newTarget) {
		this.target = newTarget;
	}

	void OnGUI() {
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
