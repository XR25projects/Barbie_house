using UnityEngine;

public class TriggerUI : MonoBehaviour
{
    public GameObject uiPanel;  // Reference to the UI Panel

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Show the UI panel when the player enters the trigger zone
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the UI panel when the player exits the trigger zone
            uiPanel.SetActive(false);
        }
    }
}
