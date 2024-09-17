using UnityEngine;

public class GameCar : MonoBehaviour
{
	[SerializeField] private float speedUp = 5.0f;

	void Update()
	{
		Vector3 vector = new(0, 0, -speedUp * Time.deltaTime);
		transform.position += vector;
		
		if (transform.position.y < -10.0f)
		{
			Destroy(gameObject);
		}
	}
}