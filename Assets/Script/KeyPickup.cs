using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();
            player.keys += 1;

            Debug.Log("Picked up key! Total keys: " + player.keys);

            Destroy(gameObject);
        }
    }
}
