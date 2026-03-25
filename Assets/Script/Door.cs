using UnityEngine;

public class Door : MonoBehaviour
{
    public int requiredKeys = 1;
    public bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();

            if (player.keys >= requiredKeys)
            {
                OpenDoor();
            }
            else
            {
                Debug.Log("Not enough keys");
            }
        }
    }

    void OpenDoor()
    {
        isOpen = true;
        gameObject.SetActive(false);
    }
}
