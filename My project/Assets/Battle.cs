using System.Threading;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public int heroHp = 100;
    public int heroAttack = 30;
    public int heroDefense = 10;
    public int monsterHp = 80;
    public int monsterAttack = 25;
    public int monsterDefense = 5;
    void Attack(int turn, Fighter attacker, Fighter target)
    {
        // 5. 작성
    }

    [ContextMenu("전투")]
    void StartBattle()
    {
        Fighter slime = new Fighter("슬라임",30,25,5);
        Fighter hero = new Fighter("영웅",100,30,10);
        slime.TakeDamage(heroAttack-monsterDefense);
        hero.TakeDamage(monsterAttack-heroDefense);
        Debug.Log(slime.hp + " " + slime.IsDead());
        Debug.Log(hero.hp + " " + hero.IsDead());
        Debug.Log(turn+"턴"+attacker.name+"의 공격"+damage+"")
    }
}

