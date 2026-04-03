using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;

    public KeyColor requiredColor;
    public int requiredAmount = 1;

    public float slideDistance = 3f;
    public float slideSpeed = 2f;

    private bool isOpen = false;
    private bool isOpening = false;
    private bool playerInRange = false;

    private PlayerKeys currentPlayer;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = door.position + door.right * slideDistance;
    }

    void Update()
    {
        // Press E to try opening
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !isOpen)
        {
            TryOpenDoor();
        }

        // Slide animation
        if (isOpening)
        {
            door.position = Vector3.Lerp(
                door.position,
                targetPosition,
                Time.deltaTime * slideSpeed
            );
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            currentPlayer = other.GetComponent<PlayerKeys>();

            DoorUI.instance.Show("Press E to open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            currentPlayer = null;

            DoorUI.instance.Hide();
        }
    }

    void TryOpenDoor()
    {
        if (currentPlayer == null) return;

        int currentKeys = currentPlayer.GetKeys(requiredColor);

        if (currentKeys == 0)
        {
            DoorUI.instance.Show("You don't have this key");
            return;
        }

        if (currentKeys < requiredAmount)
        {
            DoorUI.instance.Show("Need " + requiredAmount + " keys");
            return;
        }

        if (currentKeys == 0 && currentPlayer.TotalKeys() > 0)
        {
            DoorUI.instance.Show("Wrong key color");
            return;
        }

        DoorUI.instance.Show("Door opened");
        currentPlayer.UseKeys(requiredColor, requiredAmount);
        OpenDoor();
    }
    void OpenDoor()
    {
        isOpen = true;
        isOpening = true;
    }
}