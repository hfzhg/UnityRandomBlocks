using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Capsule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void GreenCapsule(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("GreenCapStats").gameObject.GetComponent<Text>();
		stats.text = "GreenCapsule:1";
		Destroy(gameObject);
	}
	public void BlueCapsule(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("BlueCapStats").gameObject.GetComponent<Text>();
		stats.text = "BlueCapule:1";
		Destroy(gameObject);
	}
	public void PurpleCapsule(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("PurpleCapStats").gameObject.GetComponent<Text>();
		stats.text = "PurpleCapsule:1";
		Destroy(gameObject);
	}
}
