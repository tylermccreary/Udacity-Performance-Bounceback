using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {

    public static bool isDebugging = false;

	public static void Info(string message)
    {
        if (isDebugging)
        {
            Debug.Log(message);
        }
    }
}
