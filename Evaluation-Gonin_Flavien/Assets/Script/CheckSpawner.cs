using System;
using UnityEngine;

public class CheckSpawner : MonoBehaviour
{
	private void Update()
	{
		if (transform.childCount >= 10)
		{
			GameObject.Find("Farmer").GetComponent<Deplacement>().canMove = false;
			GetComponent<Spawner>().canSpawn = false;
			foreach (Transform child in transform)
			{
				child.GetComponent<AnimalDeplacement>().canMove = false;
			}
			GameObject.Find("FruitSpawner").GetComponent<Spawner>().canSpawn = false;
			GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Desactive>().Show(true);
		}
	}
}