using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    //static to allow other scripts to interact, does not appear in inspect panel
    public static float leftSide = -3.5f;
    public static float rightSide= 3.5f;
    public float internalLeft;
    public float internalRight;
    void Update()
    {
        //to allow static vars to appear in inspect channel
        internalLeft= leftSide;
        internalRight= rightSide;
    }
}
