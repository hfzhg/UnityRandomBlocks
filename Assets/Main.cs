using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
	Text time;
	float passed = 0f;
    // Start is called before the first frame update
    void Start()
    {
		GameObject canvas = GameObject.Find("Canvas");
		time = canvas.transform.Find("Time").gameObject.GetComponent<Text>();
		createArena(20, 10);
    }
	
	void createArena(int cubeNum, int redNum){
		Debug.Log("Creating Arena...");
		System.Random r = new System.Random();
		GameObject plane = GameObject.Find("Plane");
		int cube = 0;
		int red = 0;
		int[,] matrix = new int[10,10];
		int i = 0;
		int j = 0;
		
		while(cube < cubeNum || red < redNum){
			for(j = 0; j < 10; j++){
				Debug.Log(matrix[i,j]);
				if(matrix[i,j] == 0){
					double prob = r.NextDouble();
					Debug.Log("Prob Value: " + prob);
					if(prob < redNum * 1.0 / 100 && red < redNum){
						//Place Red Cube
						matrix[i,j] = 2;
						red = red + 1;
					}else if (prob < (redNum + cubeNum) * 1.0 / 100 && cube < cubeNum){
						//Place Normal Cube
						matrix[i,j] = 1;
						cube = cube + 1;
					}
				}
			}
			i = (i + 1)%10;
		}
		GameObject cubeObj = GameObject.Find("Cube");
		GameObject redObj = GameObject.Find("RedCube");
		for (i = 0; i < 10; i++){
			for (j = 0; j < 10; j++){
				if(matrix[i,j] == 2){
					Instantiate(redObj, new Vector3(2.5f * (i - 5), 2.5f, 2.5f * (j - 5)), Quaternion.identity);
				}else if(matrix[i,j] == 1){
					Instantiate(cubeObj, new Vector3(2.5f * (i - 5), 2.5f, 2.5f * (j - 5)), Quaternion.identity);
				}
			}
		}
		randomPlace("CapsuleG", matrix);
		randomPlace("CapsuleB", matrix);
		randomPlace("CapsuleP", matrix);
		randomPlace("CylinderG", matrix);
		randomPlace("CylinderB", matrix);
		randomPlace("CylinderP", matrix);
		randomPlace("SphereG", matrix);
		randomPlace("SphereB", matrix);
		randomPlace("SphereP", matrix);
		randomPlace("Player", matrix);
	}
	void randomPlace(string objName, int[,] matrix){
		System.Random r = new System.Random();
		int x = r.Next() % 10;
		int y = r.Next() % 10;
		while(matrix[x,y]!=0){
			x = r.Next() % 10;
			y = r.Next() % 10;
		}
		matrix[x,y] = 3;
		if(objName == "Player"){
			GameObject obj = GameObject.Find(objName);
			obj.transform.position = new Vector3(2.5f * (x - 5), 2.5f, 2.5f * (y - 5));
		}else{
			GameObject obj = GameObject.Find(objName);
			Instantiate(obj, new Vector3(2.5f * (x - 5), 2.5f, 2.5f * (y - 5)), Quaternion.identity);
		}
	}

    // Update is called once per frame
    void Update()
    {
		passed = passed + Time.deltaTime;
        int seconds = Mathf.FloorToInt(passed);
		if(passed - seconds < Time.deltaTime){
			time.text = "Time Elapse:" + seconds;
		}
    }
}
