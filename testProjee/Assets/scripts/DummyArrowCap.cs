using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyArrowCap : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");

        androidJavaObject.Call("fromUnityMethod");
    }
	
	// Update is called once per frame
	void Update () {

    }
}
