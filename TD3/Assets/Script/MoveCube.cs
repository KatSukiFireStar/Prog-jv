using UnityEngine;

public class MoveCube : MonoBehaviour
{
	void Update()
	{
		transform.Translate(Vector3.forward * (Time.deltaTime * 3));
		transform.Rotate(new Vector3(0f, 45f, 0f) * Time.deltaTime);
	}
}