using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGenerator : MonoBehaviour {

	public List<Transform> tileList = new List<Transform>();

	public int mapSize = 5;
	public float tileOffset = 25;
	public int y = 0;
	public Transform tile;

	private Transform tempTile;

	// Use this for initialization
	void Start () 
	{
		GenerateMap();
	}
	
	void GenerateMap ()
	{
		for(int i = 0; i < mapSize; i++)
		{
			tempTile = Instantiate(tile, new Vector3(i, y, 0), transform.rotation) as Transform;
			tileList.Add(tempTile);
			if(i == mapSize - 1 && y < mapSize - 1)
			{
				y++;
				GenerateMap();
			}
		}
	}
}
