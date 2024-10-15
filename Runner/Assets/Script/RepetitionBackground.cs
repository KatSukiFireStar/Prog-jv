using System;
using UnityEngine;

public class RepetitionBackground : MonoBehaviour
{
	private Vector3 startPos;

	private void Start()
	{
		startPos = transform.position;
	}

	private void Update()
	{
		if (transform.position.x < -11.4f)
		{
			transform.position = startPos;
		}
	}
}