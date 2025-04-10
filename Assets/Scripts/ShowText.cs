using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowText : MonoBehaviour
{
    public string[] textValue;
    public string textValuePressed;
    public TextMeshProUGUI textElement;
    private bool fadeIn;
    private bool fadeOut;

    private float timeElapsed;
    private float valueToLerp;
    private float delayTime = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textElement.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Invoke("selectAText", 0);
        }

    }

    void selectAText()
    {
        textElement.enabled = true;
        textElement.text = textValue[Random.Range(0, textValue.Length)];
        //fadeOut = true;
        //Invoke("disappearTimer", 1);



        //if (textElement.color32.alpha < 1)
        //{
        //    textElement.color32.alpha += Time.deltaTime;
            
        //    if (textElement.color32.alpha >= 1)
        //    {
        //        fadeIn = false;
        //    }
        //}
        //Invoke("disappearTimer", 3);
    }

    void disappearTimer()
    {
        //if (fadeOut == true)
        //{
        //    fadeIn = false;
        //    valueToLerp = Mathf.Lerp(1, 0, timeElapsed / delayTime);
        //    timeElapsed += Time.deltaTime;
        //    textElement.color = new Color(textElement.color.r, textElement.color.g, textElement.color.b, valueToLerp);
        //}

        //textElement.enabled = false;
    }
}
