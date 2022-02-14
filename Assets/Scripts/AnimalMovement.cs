using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float animalForwardSpeed;
    private Rigidbody animalRb;
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        animalRb.AddForce(Vector3.forward * animalForwardSpeed, ForceMode.Force);
    }
}
