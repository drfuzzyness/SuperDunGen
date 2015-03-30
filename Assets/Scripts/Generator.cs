using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {


	public GameObject floorTile;
	public GameObject wallTile;

	[Header("Grid Customization")]
	public int iterations;
	public int tileSize;
	public int gridSize;

	private int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pathGenerationStep();
	}

	void pathGenerationStep() {
		if( counter < iterations ) {
			float seed = Random.Range( 0f, 1f );
			if( seed < .25f ) {
//				Debug.Log ( "+90") ;
				transform.Rotate( 0f, 90f, 0f );
			} else if(  seed < .5f ) {
//				Debug.Log ( "-90") ;
				transform.Rotate( 0f, -90f, 0f );
			}
			gridInstance( gridSize, gridSize );
			transform.Translate( Vector3.forward * gridSize * tileSize, Space.Self );
			counter++;
		} else {
			// i'm done
		}
	}

	void gridInstance(int gridX, int gridZ ) {
		for( int x = 0; x < gridX * tileSize; x+=tileSize ) {
			for( int z = 0; z < gridZ * tileSize; z+=tileSize ) {
				Vector3 pos = transform.position + new Vector3( x, 0, z );
				float seed = Random.Range( 0f, 1f );
				if( seed < .7f ) {
					Instantiate( floorTile, pos, transform.rotation );
				} else if ( seed < .95f ) {
					Instantiate( wallTile, pos, transform.rotation );
				}
			}
		}
		// done;
	}

}
