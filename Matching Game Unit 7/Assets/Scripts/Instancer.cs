using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public GameObject prefab1;

    public void CreateInstance() 
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj) 
    {
        Instantiate(prefab, obj.value, Quaternion.identity);

    }

    public void CreateInstanceFromList(Vector3DataList obj) 
    {
        for (var i = 0; i<obj.vector3dList.Count; i++)
        {
        Instantiate(prefab, obj.vector3dList[i].value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj) 
    {

        Instantiate(prefab, obj.vector3dList[num].value, Quaternion.identity);
        num++;
        if(num == obj.vector3dList.Count) 
        {
            num = 0;
        }
    }

    public void CreateInstanceListRandomly(Vector3DataList obj) 
    {
        num = Random.Range(0, obj.vector3dList.Count - 1);
        Instantiate(prefab, obj.vector3dList[num].value, Quaternion.identity);
    }

public void CreateInstanceListRandomly1(Vector3DataList obj) 
    {
        num = Random.Range(0, obj.vector3dList.Count - 1);
        Instantiate(prefab1, obj.vector3dList[num].value, Quaternion.identity);
    }

}
