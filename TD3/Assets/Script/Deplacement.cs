using System;
using Unity.VisualScripting;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [SerializeField] private float speedUp = 1.0f;
    [SerializeField] private float speedRight = 0.1f;
    [SerializeField] private double conso = 0.001f;

    public float SpeedUp
    {
        get => speedUp;
        set => speedUp = value;
    }

    public float SpeedRight
    {
        get => speedRight;
        set => speedRight = value;
    }
    
    GestionVoiture gestionVoiture = new();

    private void Update()
    {
        Vector3 vector = new(0, 0, speedUp * Time.deltaTime);

        if (gestionVoiture.roule(conso))
        {
            transform.position += transform.forward * (speedUp * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new(0, -speedRight * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new(0, speedRight * Time.deltaTime, 0));        
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            speedUp += 0.1f;
            if (speedUp > 50)
            {
                speedUp = 50;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            speedUp -= 0.1f;
            if (speedUp < 0)
            {
                speedUp = 0;
            }
        }
    }
}