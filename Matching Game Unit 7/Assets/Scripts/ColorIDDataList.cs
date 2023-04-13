using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentcolor;

    private int num;

    public void SetCurrentColorRandomly() 
    {
        num = Random.Range(0, colorIDList.Count - 1);
        currentcolor = colorIDList[num];

    }
}
