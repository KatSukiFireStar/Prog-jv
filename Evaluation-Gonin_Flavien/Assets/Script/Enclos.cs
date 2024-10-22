using System;
using UnityEngine;

public class Enclos : MonoBehaviour
{
	private void Update()
	{
		if (transform.childCount >= 5)
		{
			GameObject.Find("Farmer").GetComponent<Deplacement>().canMove = false;
			Transform t = GameObject.Find("AnimalSpawner").transform;
			t.GetComponent<Spawner>().canSpawn = false;
			foreach (Transform child in t)
			{
				child.GetComponent<AnimalDeplacement>().canMove = false;
			}
			GameObject.Find("FruitSpawner").GetComponent<Spawner>().canSpawn = false;
			GameObject.Find("Canvas").transform.GetChild(1).GetComponent<Desactive>().Show(true);
		}
	}
}