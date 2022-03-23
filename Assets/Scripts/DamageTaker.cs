using UnityEngine;

[RequireComponent(typeof(HealthBehaviour))]
public class DamageTaker : MonoBehaviour
{
    private HealthBehaviour healthBehaviour;

    private void Awake()
    {
        healthBehaviour = GetComponent<HealthBehaviour>();
	Debug.Log("Coucou");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        healthBehaviour.TakeDamage(1);
    }
}
