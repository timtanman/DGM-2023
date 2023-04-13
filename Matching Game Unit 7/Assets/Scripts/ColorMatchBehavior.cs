using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : Match_Behavior
{

    public ColorIDDataList colorIDDataListObj;

    public void Awake() 
    {
        idObj = colorIDDataListObj.currentcolor;
    }

    public void ChangeColor(SpriteRenderer renderer) 
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;

    }

}
