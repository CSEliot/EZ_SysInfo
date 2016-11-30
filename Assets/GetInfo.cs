using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetInfo : MonoBehaviour {

    public Text txt;
    private SystemInfo sys;

	// Use this for initialization
	void Start () {
        sys = new SystemInfo();
        var info = typeof(SystemInfo).GetProperties();
        txt.text += "\nOn: " + Application.platform;
        for(int x = 0; x < info.Length; x++) {
            if (info[x].CanRead) { 
                txt.text += "\n" + info[x].Name + ": " + info[x].GetValue(sys, null);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
