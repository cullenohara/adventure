using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestGenerator : MonoBehaviour {

	//The player's quest queue
	//Any generated quest will be placed into this list allowing the player to have multiple quests at the same time.
	public List<Quests> questList = new List<Quests>();

	//Gets the list of names from the NPC_Names game object at runtime.
	public NPCNames nameList;

	void Start ()
	{
		nameList = GameObject.FindGameObjectWithTag("npc_names").GetComponent<NPCNames>();
		print(nameList.npcNames[0]);
	}

	//Generates a quest with random
	void GenerateQuest ()
	{
		print ("Poop.");
	}
	
}