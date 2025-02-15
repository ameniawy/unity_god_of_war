using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsBehavior : MonoBehaviour {

	private Text text;
	// Use this for initialization
	private int currentQuest;
	private string[] quests;
	void Start () {
		currentQuest = 0;
		text = this.gameObject.transform.Find ("Text").GetComponent<Text>();
		quests = new string[4] {"Quest:\n- Talk to the old man by the well.", "Quest:\n- Collect the four pieces of the map.", 
			"Quest:\n- Show the map to the old man.", "Quest:\n- Go the road leading to the castle."};
	}

	public void nextQuest(int quest)
	{
		currentQuest = quest;
		text.text = quests [currentQuest];
	}
}
