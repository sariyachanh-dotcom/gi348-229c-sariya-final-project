using UnityEngine;

public class Door : MonoBehaviour
{
    public int requiredKeys = 1;
    public bool isOpen = false;
    public bool useSpecialKeys = false;

    public GameObject door;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();

            int currentKeys = useSpecialKeys ? player.specialKeys : player.keys;

            if (currentKeys >= requiredKeys)
            {
                OpenDoor(player);
            }
            else
            {
                Debug.Log("Not enough keys");
            }
        }
        void OpenDoor(PlayerKeys player)
        {
            isOpen = true;

            if (!useSpecialKeys)
            {
                player.keys -= requiredKeys; 
            }

            door.SetActive(false);
        }
    }
}
