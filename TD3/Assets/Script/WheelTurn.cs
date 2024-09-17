using UnityEngine;

public class WheelTurn : MonoBehaviour
{
	private Deplacement deplacement;

	[SerializeField] private bool rotate;

	void Start()
	{
		deplacement = GetComponentInParent<Deplacement>();
	}

	void Update()
	{
		float speed = deplacement.SpeedUp;
		float speedRight = deplacement.SpeedRight;
		
		transform.Rotate(new(speed * 10 * Time.deltaTime, 0, 0));

		if (rotate)
		{
			if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
			{
				transform.Rotate(new(0, -speedRight * Time.deltaTime, 0));
			}
			else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
			{
				transform.Rotate(new(0, speedRight * Time.deltaTime, 0));        
			}
		}
	}
}