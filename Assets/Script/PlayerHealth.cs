using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Blood : " + currentHealth);

        if (currentHealth < 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Player Die");
    }


}
