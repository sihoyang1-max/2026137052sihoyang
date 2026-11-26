using UnityEngine;

public class Fighter : MonoBehaviour
{
    public string name;
    public int hp;
    public int attack;
    public int defense;

    public Fighter(string name, int hp, int attack, int defense)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
    }
    public int GetDamageTo(Fighter target)
    {
        int damage = attack - defense;
        if (defense < 1) return 1;
        return damage;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
    }

    public bool IsDead()
    {
        return hp <= 0;
    }
}
