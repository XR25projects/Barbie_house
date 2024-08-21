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

        Debug.Log("VRPosition" + input.x + " " + input.y);

        // Calculate the movement direction based on the VR camera's forward direction
        Vector3 moveDirection = new  Vector3 (input.x, 0, input.y).normalized;

        // Move the character controller in the calculated direction
        characterController.Move(moveDirection * speed * Time.deltaTime);
    }
}
