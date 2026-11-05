using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;
    [ContextMenu("정산")]
    void Settle()
    {
        Debug.Log("플래이 시간" + 
            (playSeconds /60)/60 + "시"
            + playSeconds /60 %60 + "분"
            + playSeconds %60+ "초");
        Debug.Log("1인당" +gold/members+"G" +"리더 보너스"+gold%members+"G");
        Debug.Log("경험치" + expPerKill * kills/hits + "(기본 "+ expPerKill * kills + ")");

    }
}
