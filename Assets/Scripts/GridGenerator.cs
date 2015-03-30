using UnityEngine;
using System.Collections;

public class GridGenerator : MonoBehaviour {

	public GameObject floorTile;
	public GameObject wallTile;
	
	[Header("Grid Customization")]
	public int tileSize;
	public int gridSize;

	// Use this for initialization
	void Start () {
		for( int x = 0; x < gridSize * tileSize; x+=tileSize ) {
			for( int z = 0; z < gridSize * tileSize; z+=tileSize ) {
				Vector3 pos = transform.position + new Vector3( x, 0, z );
				float seed = Random.Range( 0f, 1f );
				if( seed < .7f ) {
					Instantiate( floorTile, pos, transform.rotation );
				} else if ( seed < 1f ) {
					Instantiate( wallTile, pos, transform.rotation );
				}
			}
		}
		Destroy( gameObject );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
