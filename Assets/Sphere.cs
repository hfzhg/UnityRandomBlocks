using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void GreenSphere(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("GreenSphereStats").gameObject.GetComponent<Text>();
		stats.text = "GreenSphere:1";
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down);
	}
	public void BlueSphere(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("BlueSphereStats").gameObject.GetComponent<Text>();
		stats.text = "BlueSphere:1";
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down);
	}
	public void PurpleSphere(){
		GameObject canvas = GameObject.Find("Canvas");
		Text stats = canvas.transform.Find("PurpleSphereStats").gameObject.GetComponent<Text>();
		stats.text = "PurpleSphere:1";
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down);
	}
}
