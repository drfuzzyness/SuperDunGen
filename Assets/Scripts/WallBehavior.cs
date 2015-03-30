using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter( Collider col ) {
		Debug.Log( "COLLERDERDER" ); 
		if( col.gameObject.tag == "Floor" ) {
			Destroy( gameObject );
		} else if( col.gameObject.tag == "Wall" ) {
			Destroy( col.gameObject );
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
