using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {

	public int npcID;
	public string firstName;
	public string lastName;
	public int questID;
	public int questAreaID;

	public Quests quest;

	void Start ()
	{
		GenerateQuest();
	}

	void GenerateQuest()
	{
		//quest = new Quests(npcID
	}

}
