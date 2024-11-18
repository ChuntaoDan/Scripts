using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System;
using System.IO;
using System.Text;

public class CylinderController : MonoBehaviour
{
    // Use this for initialization
    TcpListener listener = null;
    String msg;

    // Start is called before the first frame update
    void Start()
    {
        // Set the TcpListener on port 13000.
        Int32 port = 55001;
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");

        // TcpListener server = new TcpListener(port);
        listener = new TcpListener(localAddr, port);

        // Start listening for client requests.
        listener.Start();
        print("is listening");
    }

    // Update is called once per frame
    void Update()
    {
        if (!listener.Pending())
        {
        }
        else
        {
            print("socket comes");
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            StreamReader reader = new StreamReader(ns);
            msg = reader.ReadToEnd();
            print(msg);
        }
    }
}
