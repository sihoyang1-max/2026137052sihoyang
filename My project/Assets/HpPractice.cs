using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currntHp;
    public int maxHp;

    [ContextMenu("체력")] 
    void PrintHp()
    {

        Debug.Log("체력 : " + (float)currntHp / maxHp *100 + " %");
    }
    
}
