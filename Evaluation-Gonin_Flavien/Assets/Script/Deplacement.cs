using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Deplacement : MonoBehaviour
{
	[SerializeField] 
	private float speed;

	private float axeHorizontal;
	private float axeVertical;
	private Rigidbody rb;
	
	[HideInInspector]
	public bool canMove = true;
	[HideInInspector]
	public Vector3 movementVertical = new();
	[HideInInspector]
	public Vector3 movementHorizontal = new();
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		//Recupere les directions
		axeHorizontal = Input.GetAxis("Horizontal");
		axeVertical = Input.GetAxis("Vertical");
	}

	private void FixedUpdate()
	{
		if (!canMove)
			return;
		
		//Actualise la position en verifiant d'etre dans les limites
		movementVertical = new();
		movementHorizontal = new();
		if((axeVertical < 0 && transform.position.z > -1) || axeVertical > 0 && transform.position.z < 16)
			movementVertical = axeVertical * speed * Time.deltaTime * transform.forward;
		if((axeHorizontal < 0 && transform.position.x > -11) || axeHorizontal > 0 && transform.position.x < 11)
			movementHorizontal = axeHorizontal * speed * Time.deltaTime * transform.right;
		
		rb.MovePosition(rb.position + movementHorizontal + movementVertical);
	}
}