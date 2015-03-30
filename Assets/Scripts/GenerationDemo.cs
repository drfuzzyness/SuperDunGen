using UnityEngine;
using System.Collections;

public class GenerationDemo : MonoBehaviour {

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		Instantiate( prefab, Random.onUnitSphere * 5f, Random.rotation );
	}
	
	// Update is called once per frame
	void Update () {
	}
}
