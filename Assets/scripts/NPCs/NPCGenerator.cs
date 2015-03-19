using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCGenerator : MonoBehaviour {

	private MapGenerator tileArray;
	private int npcCount;
	private int npcGenCount;
	private int getTile;

	public Transform npcPrefab;
	private Transform tempNPC;

	private NPCList npcList;

	private NPCNames namesList;
	private NPCNames firstNames;
	private NPCNames lastNames;

	private int randomFirst;
	private int randomLast;

	// Use this for initialization
	void Start () {
		npcList = GameObject.FindGameObjectWithTag("npc_list").GetComponent<NPCList>();
		tileArray = GameObject.FindGameObjectWithTag("map_generator").GetComponent<MapGenerator>();
		namesList = GameObject.FindGameObjectWithTag("npc_names").GetComponent<NPCNames>();
		npcCount = GameObject.FindGameObjectWithTag("quest_area_gen").GetComponent<QuestAreaGenerator>().questAreaCount;
		FindTile();
	}

	void FindTile ()
	{
		getTile = Random.Range(0, tileArray.tileList.Count);
		if(tileArray.tileList[getTile].gameObject.GetComponent<Tile>().inUse == false)
		{
			GenerateNPC();
		}
		else
		{
			FindTile();
		}
	}

	void GenerateNPC ()
	{
		if(npcGenCount < npcCount)
		{
			tempNPC = Instantiate(npcPrefab, new Vector3(tileArray.tileList[getTile].transform.position.x, tileArray.tileList[getTile].transform.position.y, tileArray.tileList[getTile].transform.position.z), tileArray.tileList[getTile].transform.rotation) as Transform;
			randomFirst = Random.Range(0, namesList.firstNames.Count);
			randomLast = Random.Range(0, namesList.lastNames.Count);
			tempNPC.GetComponent<NPC>().firstName = namesList.firstNames[randomFirst];
			tempNPC.GetComponent<NPC>().lastName = namesList.lastNames[randomLast];
			tempNPC.GetComponent<NPC>().npcID = npcGenCount;
			tileArray.tileList[getTile].gameObject.GetComponent<Tile>().inUse = true;
			npcList.npcList.Add(tempNPC);
			npcGenCount++;
			FindTile();
		}
	}
}
