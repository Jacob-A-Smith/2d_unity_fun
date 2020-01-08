using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour {

	//List<GameObject> spells;

	// Use this for initialization
	void Start () {
		//spells = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CastSpell(GameObject spell, Transform initialPosition) {
		GameObject spellCast = Instantiate (spell, new Vector3 (initialPosition.position.x, initialPosition.position.y, 0), Quaternion.identity);
		spellCast.transform.parent = this.gameObject.transform;
		spellCast.GetComponent<SpellBehaviour>().move = true;

		//spells.Add(Instantiate (spell, new Vector3 (initialPosition.position.x, initialPosition.position.y, 0), Quaternion.identity));
	}
}
