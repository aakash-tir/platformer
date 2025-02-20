using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; 
    public float rotationSpeed = 50f; 

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
