using UnityEngine;
using Oculus;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0f;               // Movement speed
    public Transform vrCamera;               // Reference to the VR camera
    private CharacterController characterController;

    void Start()
    {
        // Get the CharacterController component attached to the PlayerController
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get the primary thumbstick's input
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        // Calculate the movement direction based on the VR camera's forward direction
        Vector3 moveDirection = vrCamera.forward * input.y + vrCamera.right * input.x;

        // Flatten the movement direction on the Y axis to prevent vertical movement
        moveDirection.y = 0;

        // Move the character controller in the calculated direction
        characterController.Move(moveDirection * speed * Time.deltaTime);
    }
}
