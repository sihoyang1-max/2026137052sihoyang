using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;
    public Slider hpslider;
    public float invincibleTime = 0f;
    public GameObject dropPrefab;
    public float dropChance = 0.3f;
    public GameObject hitEffect;
    public static int killCount;
    float IastHitTime = -999f;
    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        if (Time.time < IastHitTime + invincibleTime)
            return;
        IastHitTime = Time.time;

        currentHp -= damage;
        Debug.Log(name + " Hp: " + currentHp);
        UpdateBar();
        Vector3 hitPos = transform.position + Vector3.up;
        if (hitEffect != null)
            Instantiate(hitEffect, hitPos,
                Quaternion.identity);

        if (currentHp <= 0) Die();
        else Blink();
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UpdateBar();
    }
    // Update is called once per frame
    void UpdateBar()
    {
        if (hpslider != null)
            hpslider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            killCount++;
            if (dropPrefab != null &&
                Random.value < dropChance)
            {
                Vector3 pos = transform.position
                    + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos,
                    Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
    void Blink()
    {
        SetVisible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }

    void ShowAgain()
    {
        SetVisible(true);
    }

    void SetVisible(bool on)
    {
        foreach (Renderer r in
                 GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }
}
    
