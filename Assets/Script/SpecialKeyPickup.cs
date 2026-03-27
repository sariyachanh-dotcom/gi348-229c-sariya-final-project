using UnityEngine;

public class SpecialKeyPickup : MonoBehaviour
{
    public GameObject scaryQuad;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();
            player.specialKeys += 1;

            Debug.Log("Picked SPECIAL key! Total: " + player.specialKeys);
            Debug.Log("Jumpscare triggered!");

            if (scaryQuad != null)
            {
                scaryQuad.SetActive(true);
            }
            else
            {
                Debug.Log("ScaryQuad not assigned!");
            }

            Destroy(gameObject);
        }
    }
}
