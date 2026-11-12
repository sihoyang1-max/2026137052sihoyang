using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;
    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;

        for ( /*몬스터를 한마리 잡을때 마다 */ int i = 1;i <= killCount;i++)
        {
            // 경험치 상승 시키고
            
            exp += expPerKill;

            while (exp > level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log("레벨업! Lv " + level + "(" + killCount + " 마리째)");
            }
        }


       Debug.Log("최종 Lv " + level + ", 경험치 " + exp + "/" + level+"0000");
    }
}
