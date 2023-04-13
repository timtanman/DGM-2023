using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainer_Behavior
{

    public ColorIDDataList colorIDDataListObj;

    public void Awake() 
    {
        idObj = colorIDDataListObj.currentcolor;
    }
}
