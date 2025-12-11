using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportDestination;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If disc collides with Bat1, teleport to Bat2
        if (other.CompareTag("Disc"))
        {
            other.transform.position = teleportDestination.position;
        }
    }
}
