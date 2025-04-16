using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowText : MonoBehaviour
{
    SerialPort serialPort = new SerialPort("COM3", 9600); // Update COM port if needed

    public string[] textValue;
    public string textValuePressed;
    public TextMeshProUGUI textElement;
    private bool fadeIn;
    private bool fadeOut;

    private float timeElapsed;
    private float valueToLerp;
    private float delayTime = 3f;

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        //string data = serialPort.ReadLine();
        //int sensorValue = int.Parse(data);
        //Debug.Log(data);

        textElement.enabled = true;
        textElement.text = textValue[Random.Range(0, textValue.Length)];


        //textElement.enabled = true;
        //textElement.text = textValue[Random.Range(0, textValue.Length)];
    }

    //Invoked when a connect/disconnect event occurs. The parameter 'success'
    //will be 'true' upon connection and 'false' upoin disconnection or
    //failure to connect.
    void OnConnectionEvent(bool success)
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textElement.enabled = false;
        serialPort = new SerialPort("COM3", 9600);
        serialPort.Open();
        serialPort.ReadTimeout = 100; // Optional
        Debug.Log(serialPort);
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
                
                string data = serialPort.ReadLine();
                //int sensorValue = int.Parse(data);
                Debug.Log(data);

                textElement.enabled = true;
                textElement.text = textValue[Random.Range(0, textValue.Length)];

                // Use sensorValue to drive Unity logic
        
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           Debug.Log("Mouse pressed");
            textElement.enabled = true;
            textElement.text = textValue[Random.Range(0, textValue.Length)];
        }

    }

    void selectAText()
    {

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
