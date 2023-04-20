using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalse;
    public intData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    public bool canRun;
    // Start is called before the first frame update
    public void Start() 
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
    }

    public void StartCounting() 
    {
        StartCoroutine(routine:Counting());
    }
    public IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0) 
        {
            Debug.Log(counterNum.value);
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
            
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse() 
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    public IEnumerator RepeatUntilFalse() 
    {
        while(canRun) 
        {
            yield return wfsObj;
            repeatUntilFalse.Invoke();
        }

    }

    public bool CanRun 
    {
        get => canRun;
        set => canRun = value;
    }


  

}
