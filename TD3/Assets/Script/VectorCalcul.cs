using System;
using UnityEngine;

public class VectorCalcul : MonoBehaviour
{
	private void Start()
	{
		Debug.Log(new Vector2(5,8) + new Vector2(3, 2));
		Debug.Log(new Vector2(-1,-3) + new Vector2(-2, 2));
		Debug.Log(new Vector3(-2,-1,5) + new Vector3(1, 4,3));
		Debug.Log(new Vector3(2,-4,1) + new Vector3(-1, -1,3));
	}
}