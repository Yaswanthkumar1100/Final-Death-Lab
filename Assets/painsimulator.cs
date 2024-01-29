using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
using System;
using System.Threading;

public class painsimulator : MonoBehaviour
{
    Thread IOThread = new Thread(DataThread);
    private static SerialPort sp;
    private static string outgoingMsg = "";

    private static void DataThread()
    {
        sp = new SerialPort("COM8", 9600);
        if (sp.IsOpen == false) ;
        {
            sp.Open();
        }
        while (true)
        {
            if (outgoingMsg != "")
            {
                sp.Write(outgoingMsg);
                outgoingMsg = "";
            }
        }
    }

    private void OnDestroy()
    {
        IOThread.Abort();
        sp.Close();
    }



    void Start()
    {
        IOThread.Start();
        outgoingMsg = "d";


    }

    void Update()
    {


    }


}