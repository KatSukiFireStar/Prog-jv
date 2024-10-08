using System;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] 
	private List<GameObject> animals = new();

	[SerializeField] 
	private float timeBetweenSpawns;
	
	public ScoreCounter scoreCounter;
	
	private float timer;

	private void Awake()
	{
		timer = timeBetweenSpawns;
	}

	private void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			timer = timeBetweenSpawns;
			GameObject animal = animals[UnityEngine.Random.Range(0, animals.Count)];
			Instantiate(animal, new(UnityEngine.Random.Range(-11, 11), transform.position.y, transform.position.z), animal.transform.rotation, gameObject.transform);
		}
	}
}