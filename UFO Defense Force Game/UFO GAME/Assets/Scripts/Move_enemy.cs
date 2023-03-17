using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_enemy : MonoBehaviour
{
    public Vector3 startPosition;

    public Vector3 endPosition;

    public float moveTime = 2.0f;

    private float timer = 0.0f;

    private void Start()
    {
        transform.position = startPosition;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        Vector3 newPosition = Vector3.Lerp(startPosition, endPosition, timer / moveTime);

        if (newPosition == endPosition)
        {
            Vector3 temp = startPosition;
            startPosition = endPosition;
            endPosition = temp;

            timer = 0.0f;
        }

        transform.position = newPosition;
    }
}
