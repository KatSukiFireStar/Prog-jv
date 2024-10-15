using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeMaterial : MonoBehaviour
{
	private void Start()
	{
		foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
		{
			Debug.Log(mr.gameObject.name);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			GetComponent<MeshRenderer>().material.color = new(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		if (Input.GetKeyDown(KeyCode.R))
		{
			foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
			{
				if (mr.gameObject.name.Contains("Pillar"))
				{
					mr.transform.localScale *= 0.75f;
				}
			}
		}
	}
}