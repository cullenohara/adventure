using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Quests {

	public int npcID; //Who is the quest giver?
	public string npcName; //What is their name?
	public string questName; //What is the name of the quest?
	public QuestType questType; //Is this a kill, find, or escort quest?
	public QuestLocations questLocation; //Where does the player need to go?
	public string questObjective; //The NPCs description will be generated using information from the type, location, and reward

	public string findItem; //What does the player need to find?
	public int findAmount; //How many?

	public string killNPC; //What type of NPC does the player need to kill?
	public int killAmount; //How many?

	public string escortNPC; //Who does the player need to escort?
	public string escortLocation; //Where does the player need to take them?
	
	public string rewardItem; //What is the reward?
	public int rewardAmount; //How many does the player receive?

	public Quests(int _npcID, string _npcName, string _questName, QuestType _type, QuestLocations _location, string _objective, string _findItem, int _findAmount, 
	              string _killNPC, int _killAmount, string _escortNPC, string _escortLocation, string _rewardItem, int _rewardAmount)
	{
		npcID = _npcID;
		npcName = _npcName;
		questName = _questName;
		questType = _type;
		questLocation = _location;
		questObjective = _objective;
		findItem = _findItem;
		findAmount = _findAmount;
		killNPC = _killNPC;
		killAmount = _killAmount;
		escortNPC = _escortNPC;
		escortLocation = _escortLocation;
		rewardItem = _rewardItem;
		rewardAmount = _rewardAmount;
	}

	public enum QuestType
	{
		kill,
		find,
		escort
	}

	public enum QuestLocations
	{
		cave,
		sewer,
		house,
		barn
	}
}