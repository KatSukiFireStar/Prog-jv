using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private float depAxeVert;
    private float depAxeHor;
    
    private float vitesse = 10f;
    private float vitesseRot = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        depAxeVert = Input.GetAxis("Vertical");
        depAxeHor = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Deplacement();
        Rotation();
    }

    private void Deplacement()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Vector3 move =   vitesse * Time.deltaTime * depAxeVert * transform.forward;
        rigidbody.MovePosition(rigidbody.position + move);
        rigidbody.velocity = Vector3.zero;
    }

    private void Rotation()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        float angle = depAxeHor * Time.deltaTime * vitesseRot;
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        rigidbody.MoveRotation(rigidbody.rotation * rotation);
        rigidbody.angularVelocity = Vector3.zero;
    }
}
