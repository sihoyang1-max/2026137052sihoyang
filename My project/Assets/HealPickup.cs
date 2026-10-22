using UnityEngine;

public class HealPickup : MonoBehaviour
{
    public int amount = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);   
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        other.GetComponent<Health>().Heal(amount);
        Destroy(gameObject);
    }
}
