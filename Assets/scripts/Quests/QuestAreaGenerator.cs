using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestAreaGenerator : MonoBehaviour {

	public Transform questAreaPrefab;
	public MapGenerator tileArray;

	private int getTile;

	public int questAreaCount;
	private int questAreaGenCount;

	public Transform tempQuestArea;

	public Quest_Area_List qaList;

	// Use this for initialization
	void Start () 
	{
		tileArray = GameObject.FindGameObjectWithTag("map_generator").GetComponent<MapGenerator>();
		qaList = GameObject.FindGameObjectWithTag("quest_area_list").GetComponent<Quest_Area_List>();
		questAreaCount = Random.Range(2,5);
		FindTile();
	}
	
	void FindTile ()
	{
		getTile = Random.Range(0, tileArray.tileList.Count);
		if(tileArray.tileList[getTile].gameObject.GetComponent<Tile>().inUse == false)
		{
			GenerateQuestArea();
		}
		else
		{
			FindTile();
		}
	}
	
	void GenerateQuestArea ()
	{
		if(questAreaGenCount < questAreaCount)
		{
			tempQuestArea = Instantiate(questAreaPrefab, new Vector3(tileArray.tileList[getTile].transform.position.x, tileArray.tileList[getTile].transform.position.y, tileArray.tileList[getTile].transform.position.z), tileArray.tileList[getTile].transform.rotation) as Transform;
			qaList.QuestAreaList.Add(tempQuestArea);
			tileArray.tileList[getTile].gameObject.GetComponent<Tile>().inUse = true;
			questAreaGenCount++;
			FindTile();
		}
	}
}
