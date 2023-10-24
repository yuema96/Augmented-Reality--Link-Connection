using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;


public class WS_Client: MonoBehaviour
{
    WebSocket ws;

    private void Start()
    {
        ws = new WebSocket("ws://localhost:8080");
        ws.Connect();
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+ (e.Data));
            JsonDataClass jsnData=JsonUtility.FromJson<JsonDataClass>(e.Data);
            // Debug.Log(jsnData.position_main);

            Debug.Log("Main window's current x position value is "+jsnData.position_main[jsnData.position_main.Count-1].x);
            Debug.Log("Main window's current y position value is "+jsnData.position_main[jsnData.position_main.Count-1].y);
            Debug.Log("Child window1's current x position value is "+jsnData.position_w1[jsnData.position_w1.Count-1].x);
            Debug.Log("Child window1's current y position value is "+jsnData.position_w1[jsnData.position_w1.Count-1].y);
            // foreach (positionList m in jsnData.position_main){
            //     Debug.Log("x is"+ m.x);
            // }

        };
    }
    private void Update()
    {
        if(ws == null)
        {
            return;
        }
    if (Input.GetKeyDown(KeyCode.Space))
        {
            ws.Send("Hello!!");
        }  
    }

}
