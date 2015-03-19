using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class NPC {

	public string npcName;
	public bool hasQuest;

	public NPC (string _npcName, bool _hasQuest)
	{
		npcName = _npcName;
		hasQuest = _hasQuest;
	}
}
