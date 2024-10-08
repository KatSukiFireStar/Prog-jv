using System;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
	[SerializeField] 
	private int speed;
	
	private void Update()
	{
		transform.Translate(speed * Time.deltaTime * Vector3.forward);
	}
}