using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Change : MonoBehaviour {
    public Color startColor = Color.blue;
    public Color endColor = Color.yellow;
    public float duration = 1.0f;
    
    private float t = 0.0f;
    private new Renderer renderer;

    void Start() {
        renderer = GetComponent<Renderer>();
    }

    void Update() {
        t += Time.deltaTime / duration;
        renderer.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(t, 1.0f));
    }
}
