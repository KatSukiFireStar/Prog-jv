using System;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
	[HideInInspector]
	public int score = 0;

	private void Start()
	{
		gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
	}

	private void Update()
	{
		gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
	}
}