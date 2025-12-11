using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportDestination;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // If disc collides with Bat1, teleport to Bat2
        if (collider.CompareTag("Disc"))
        {
            collider.transform.position = teleportDestination.position;

            Rigidbody2D rb = collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero; // Reset velocity
            }
        }
    }
}
