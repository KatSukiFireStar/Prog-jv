using System;
using System.Net.Security;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource), typeof(Animator))]
public class ControlePersonnage : MonoBehaviour
{
	private float depAxeVert;
	private float depAxeHor;
	
	[SerializeField]
	private float vitesse = 10f;
	
	[SerializeField]
	private float vitesseSaut = 2000f;
	
	[SerializeField] 
	private float gravity = 3;
	
	[SerializeField] 
	private ForceMode forceMode;
	
	[SerializeField]
	private Spawner spawner;
	[SerializeField] 
	private GameObject menu;
	[SerializeField] 
	private ParticleSystem particleSystem;
	[SerializeField] 
	private ParticleSystem jumpParticleSystem;
	[SerializeField] 
	private AudioClip jumpSound;
	[SerializeField] 
	private AudioClip deathSound;
	
	private Rigidbody rb;
	private AudioSource audioSource;
	private bool isGrounded = true;
	[HideInInspector]
	public Animator animator;
	[HideInInspector]
	public bool gameOver = false;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
		Physics.gravity *= gravity;
		jumpParticleSystem.Stop();
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (gameOver)
			return;
		
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(Vector3.up * vitesseSaut, forceMode);
			isGrounded = false;
			animator.SetTrigger("Jump_trig");
			jumpParticleSystem.Stop();
			audioSource.PlayOneShot(jumpSound);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Ground")
		{
			isGrounded = true;
			jumpParticleSystem.Play();
		}
			
		if (other.gameObject.CompareTag("Obstacle"))
		{
			particleSystem.Play();
			gameOver = true;
			spawner.gameOver = true;
			menu.SetActive(true);
			animator.SetFloat("Speed_f", 0f);
			animator.SetBool("Death_b", true);
			jumpParticleSystem.Stop();
			audioSource.PlayOneShot(deathSound);
		}
			
	}
}