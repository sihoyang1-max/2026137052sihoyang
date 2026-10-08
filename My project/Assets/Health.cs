using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;
    public Slider hpslider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;

        currentHp -= damage;
        Debug.Log(name + " Hp: " + currentHp);
        UpdateBar();

        if (currentHp <= 0) Die();
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
            Debug.Log("게임 오버");
            Time.timeScale = 0f;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
