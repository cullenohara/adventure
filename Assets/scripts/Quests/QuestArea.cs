using UnityEngine;
using System.Collections;

public class QuestArea : MonoBehaviour {

	public int questID;
	public bool inUse = false;
	public int npcConnectionID;

	void OnMouseEnter ()
	{
		print ("Connected NPC ID: " + npcConnectionID);
		//print ("Quest ID: " + questID);
	}
}
