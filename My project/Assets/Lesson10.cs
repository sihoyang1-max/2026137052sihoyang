using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("점")]
    void Stairs()
    {
        int height = 3;
        string result = "";
        
        for (int row = 1; row <=height; row++)
        {
            for (int col = 1; col <height; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
}
