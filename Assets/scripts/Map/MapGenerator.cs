using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

	public int mapSize = 5;
	public float tileOffset = 1.2f;
	public Transform tile;

	private Transform tempTile;

	// Use this for initialization
	void Start () 
	{
		for(int i = 0; i < mapSize; i++)
		{
			//tempTile = Instantiate(tile, new Vector3(i + tileOffset, 0, 0), transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
