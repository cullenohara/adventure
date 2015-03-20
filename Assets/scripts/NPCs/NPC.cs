using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

	public int npcID;
	public string firstName;
	public string lastName;
	public int questID;
	public int questAreaID;

	private int randomQuestArea;
	private Color questAreaColor;
	private Text nameText;

	//public Quests quest;
	public Quest_Area_List qaList;

	void Start ()
	{
		qaList = GameObject.FindGameObjectWithTag("quest_area_list").GetComponent<Quest_Area_List>();
		nameText = GameObject.FindGameObjectWithTag("name_text").GetComponent<Text>();
		FindQuestArea();
	}

	void FindQuestArea ()
	{
		randomQuestArea = Random.Range(0, qaList.QuestAreaList.Count);

		if(qaList.QuestAreaList[randomQuestArea].gameObject.GetComponent<QuestArea>().inUse == false)
		{
			questAreaID = randomQuestArea;
			qaList.QuestAreaList[randomQuestArea].GetComponent<QuestArea>().npcConnectionID = npcID;
			qaList.QuestAreaList[randomQuestArea].GetComponent<QuestArea>().inUse = true;
		}
		else
		{
			FindQuestArea();
		}
	}

	void OnMouseEnter ()
	{
		questAreaColor = qaList.QuestAreaList[questAreaID].GetComponent<Renderer>().material.color;
		qaList.QuestAreaList[questAreaID].GetComponent<Renderer>().material.color = Color.red;
		nameText.text = "Character Name: " + firstName + " " + lastName;
	}

	void OnMouseExit ()
	{
		qaList.QuestAreaList[questAreaID].GetComponent<Renderer>().material.color = questAreaColor;
		nameText.text = "Character Name: ";
	}
}
