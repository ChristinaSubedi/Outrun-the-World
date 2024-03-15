using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int cointCount = 0;
    public GameObject coinEndDisplay;
    public GameObject coinCountDisplay;
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + cointCount;
        coinEndDisplay.GetComponent<Text>().text ="" + cointCount;
    }
}
