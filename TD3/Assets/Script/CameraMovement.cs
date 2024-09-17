using System;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	private Deplacement deplacement;
	private float speed;

	void Start()
	{
		deplacement = target.GetComponent<Deplacement>();
	}
	
	void Update()
	{
		speed = deplacement.SpeedUp;
		transform.LookAt(target.position + new Vector3(0,5,0));
		transform.position = Vector3.MoveTowards(transform.position, target.position + new Vector3(0,6,0), speed *
			Time.deltaTime);
	}
}