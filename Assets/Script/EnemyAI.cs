using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    public float killDistance = 1.5f;
    private PlayerRespawn playerRespawn;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerRespawn = player.GetComponent<PlayerRespawn>();
    }

    void Update()
    {
        agent.SetDestination(player.position);

        float dist = Vector3.Distance(transform.position, player.position);

        if (dist < killDistance)
        {
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        if (playerRespawn != null)
        {
            playerRespawn.Respawn();
        }
    }
}