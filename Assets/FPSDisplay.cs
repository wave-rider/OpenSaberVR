using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FPSDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public float deltaTime;
    public int fps;
    public float frameTime;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		float fps = 1.0f / deltaTime;
        fps = Mathf.Ceil (fps);
        frameTime = deltaTime;
        text.text = "FPS: "+fps+"\n"+"Frametime: "+frameTime;
    }
}
