using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Match_Behavior : MonoBehaviour
{

    public ID idObj;
    public ID otherID;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;

    private IEnumerator OnTriggerEnter(Collider other) 
    {
        var tempObj = other.GetComponent<IDContainer_Behavior>();
        if (tempObj == null)
            yield break;
        
        
        var otherID = tempObj.idObj;
        if(otherID == idObj)
        {
            matchEvent.Invoke();
            Debug.Log("This is the match event");
        }
        else 
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            Time.timeScale = 0f;
            Time.timeScale = 1f;
            noMatchDelayedEvent.Invoke();
        }
    }

public void DestroyOnTrigger(Collider collider)
{
    // Wait for half a second
    StartCoroutine(DestroyAfterDelay(collider.gameObject, 0.1f));
}

public IEnumerator DestroyAfterDelay(GameObject obj, float delay)
{
    yield return new WaitForSeconds(delay);

    // Destroy the game object
    Destroy(obj);
}

}
