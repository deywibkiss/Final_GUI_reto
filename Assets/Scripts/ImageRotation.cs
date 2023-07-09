using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotation : MonoBehaviour
{
    public float rotationAmount = 30f; // Ángulo de rotación deseado
    public float rotationSpeed = 1f; // Velocidad de rotación

    private float direction = 1f; // Dirección de rotación (-1 para invertir)

    private void Update()
    {
        // Calcula el ángulo de rotación en el rango deseado
        float angle = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount * direction;

        // Calcula la rotación actual
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);

        // Aplica la rotación
        transform.rotation = targetRotation;
    }
}



