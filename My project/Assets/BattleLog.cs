using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;
    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
        int criticalLine = 3000;
        int sum = 0;
        List<int> criticals = new List<int>();
        List<int> a = new List<int>();
        for (int i = 0; i < damages.Length; i++)
        {
            sum += damages[i];
        }
        foreach(int damage in damages)
        {
            if (damage > criticalLine)
            {
                criticals.Add(damage);
            }
        }
        Debug.Log("총 데미지"+ sum);
        Debug.Log("치명타" +criticals.Count+"회");
        foreach(int crti in criticals)
        {
        Debug.Log("치명타" + crti);

        }
    
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
