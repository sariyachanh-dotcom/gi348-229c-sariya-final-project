using UnityEngine;

public class SpecialKeyPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();
            player.specialKeys += 1;

            Debug.Log("Picked SPECIAL key! Total: " + player.specialKeys);

            Destroy(gameObject);
        }
    }
}
