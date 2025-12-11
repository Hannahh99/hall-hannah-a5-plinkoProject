using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject disc;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Disc") && collision.gameObject.name == "Disc(Clone)")
        {
            DuplicateDisc(collision.gameObject);
        }
    }
        void DuplicateDisc(GameObject disc)
    {
        Vector3 position = transform.position + new Vector3(1f, 3f, 0); // Offset
        Quaternion rotation = disc.transform.rotation;
        GameObject discCopy = Instantiate(disc, position, rotation);
    }
}