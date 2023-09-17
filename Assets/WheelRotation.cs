using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    //Reference
    public Rigidbody parentRigidbody;

    public float rotationSpeed = 10.0f;

    void Update()
    {
        // Get the velocity of the parent Rigidbody
        float velocity = parentRigidbody.velocity.magnitude;

        // Calculate rotation speed based on velocity
        float wheelRotationSpeed = velocity * rotationSpeed;
    }
}
