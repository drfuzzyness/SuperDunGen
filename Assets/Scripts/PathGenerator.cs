using UnityEngine;
using System.Collections;

public class PathGenerator : MonoBehaviour {

//	public GameObject floorTile;
//	public GameObject wallTile;

	public GameObject pathGenerator;
	public GameObject gridGenerator;
	
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
		if( counter < iterations ) {
			float seed = Random.Range( 0f, 1f );
			if( seed < .25f ) {
				//				Debug.Log ( "+90") ;
				transform.Rotate( 0f, 90f, 0f );
			} else if(  seed < .5f ) {
				//				Debug.Log ( "-90") ;
				transform.Rotate( 0f, -90f, 0f );
			} else if( seed > .90f ) {
				createPath();
			}
			createNewGridTile();
			transform.Translate( Vector3.forward * gridSize * tileSize, Space.Self );
			counter++;
		} else {
			Destroy( gameObject );
		}
	}

	void OnTriggerEnter( Collider col ) {
		Debug.Log( col );
		Destroy( col.gameObject );
	}

	void createNewGridTile() {
		GridGenerator newGridGenerator = Instantiate( gridGenerator, transform.position, transform.rotation ) as GridGenerator;
	}

	void createPath() {
		GameObject newPathGenerator = Instantiate( pathGenerator, transform.position, transform.rotation ) as GameObject;
		pathGenerator.GetComponent<PathGenerator>().iterations = 5;
	}
}
