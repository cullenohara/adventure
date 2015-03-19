using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestGenerator : MonoBehaviour {

	public GameObject questGenerator;
	public QuestTypes questType;

	//The player's quest queue
	//Any generated quest will be placed into this list allowing the player to have multiple quests at the same time.
	public List<Quests> questList = new List<Quests>();

	void Start ()
	{
		questGenerator = GameObject.FindGameObjectWithTag("quest_generator");
		questType = questGenerator.GetComponent<QuestTypes>();
		print(questType.questTypes[0]);
	}

	//Generates a quest with random
	void GenerateQuest ()
	{
		print ("Poop.");
	}
	
}