using UnityEngine;
using System.Collections;

public class CubeGod : MonoBehaviour {

	public Transform blueprint;
	public int cubes;
	public float cubeSpawnRadius;


	// Use this for initialization
	void Start () {
		for( int i = 0; i < cubes; i++ ) { // make a bunch
			//makeACube();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown( KeyCode.R ) ) {
			Application.LoadLevel( Application.loadedLevel );
		}
		if( Input.GetMouseButton( 0 ) ) {
			makeACube();
		}
	}

	void makeACube() {
		Instantiate( blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation );
	}
}
