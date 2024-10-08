using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
	[SerializeField]
	private int posZToDestroy;

	private void Update()
	{
		if (transform.position.z <= posZToDestroy)
		{
			Destroy(gameObject);
		}
	}
	
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
		{
			Destroy(gameObject);
			Destroy(collision.gameObject);
			transform.parent.GetComponent<Spawner>().scoreCounter.score++;
		}
	}
}