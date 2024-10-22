using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] 
	private int timeBetweenSpawns;
	
	[SerializeField] 
	private List<GameObject> objects = new();
	
	[HideInInspector]
	public bool canSpawn = true;

	private void Start()
	{
		InvokeRepeating("Spawn", 0f, timeBetweenSpawns);
	}

	private void Spawn()
	{
		if (!canSpawn)
			return;
		
		//Choisis la position aléatoirement dans la scene et instancie un gameObject aléatoire
		Vector3 spawnPosition = new Vector3(Random.Range(-11f, 11f), 0, Random.Range(-1f, 16f));
		Instantiate(objects[Random.Range(0, objects.Count)], spawnPosition, Quaternion.identity, transform);
	}
}