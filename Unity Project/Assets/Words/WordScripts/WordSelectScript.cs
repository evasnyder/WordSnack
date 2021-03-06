using UnityEngine;
using System.Collections;
//written by ISAIAH MANN
public class WordSelectScript : MonoBehaviour {
	bool selected = false;
	//script reference
	VariableControl variables;
	// Use this for initialization
	void Start () {
		//establishes script reference
		variables = GameObject.Find("GameController").GetComponent<VariableControl>();
	}
	
	// Update is called once per frame
	void Update () {
		//toggles the word inactive if it has been consumed
		if (variables.wordSelected == false && selected == true) {
			toggleSelect();
		}
	}

	void OnMouseDown() {
		//toggles the character active or inactive based on current state
		toggleSelect();
	}

	void toggleSelect () {
		if (selected == false) { //actives the word
			gameObject.transform.localScale = new Vector3 (4, 2, 2);
			variables.wordSelected = true;
			selected = true;
		} else { //deactivates the word
			gameObject.transform.localScale = new Vector3 (2, 1, 1);
			variables.wordSelected = false;
			selected = false;

		}
	}
}
