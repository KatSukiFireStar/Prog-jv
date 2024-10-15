using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] 
	private List<GameObject> objects;
	
	[HideInInspector]
	public bool gameOver = false;

	private void Start()
	{
		InvokeRepeating("Spawn", 0f, 3f);
	}

	private void Spawn()
	{
		if (gameOver)
			return;
		
		Instantiate(objects[Random.Range(0, objects.Count)], transform.position, Quaternion.identity, transform);
	}
}