using UnityEngine;
using System.Collections;

public class Quests : MonoBehaviour {

	public string name;
	public string text;
	public string item;
	public int amount;

	public Quests(string questName, string questText, string questItem, int itemAmount)
	{
		name = questName;
		text = questText;
		item = questItem;
		amount = itemAmount;
	}
}
