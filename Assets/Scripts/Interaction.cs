using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

	bool over = false;

	// Use this for initialization
	void Start () {
		over = false;
	}

	void OnMouseOver() {
//		Debug.Log( "over" );
		if( !over ) {
			over = true;
			transform.localScale *=  2;
		}
	}

	void OnMouseHover() {
//		Debug.Log("hover");
	}

	void OnMouseExit() {
//		Debug.Log("exit");
		if( over ) {
			over = false;
			transform.localScale /=  2;
		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
