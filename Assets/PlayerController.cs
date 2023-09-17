using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 45.0f;

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * 5.0f);
    }
}
