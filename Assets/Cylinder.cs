using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void GreenCylinder(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("GreenCylinderStats").gameObject.GetComponent<Text>();
		stats.text = "GreenCylinder:1";
		Destroy(gameObject);
	}
	public void BlueCylinder(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("BlueCylinderStats").gameObject.GetComponent<Text>();
		stats.text = "BlueCylinder:1";
		Destroy(gameObject);
	}
	public void PurpleCylinder(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("PurpleCylinderStats").gameObject.GetComponent<Text>();
		stats.text = "PurpleCylinder:1";
		Destroy(gameObject);
	}
}
