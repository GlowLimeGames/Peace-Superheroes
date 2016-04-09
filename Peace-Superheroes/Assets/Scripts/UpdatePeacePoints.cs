using UnityEngine;
using System.Collections;
using Fungus;
using UnityEngine.UI;

public class UpdatePeacePoints : MonoBehaviour {

    public Flowchart flowchart;
    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "PeacePoints: " + flowchart.GetVariable<IntegerVariable>("PeacePoints").value;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "PeacePoints: " + flowchart.GetVariable<IntegerVariable>("PeacePoints").value;
    }
}
