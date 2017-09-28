﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RespawnScript : MonoBehaviour {

	public Transform player;
	public Transform SpawnPoint;

	public static Action StopMove;
	public static Action StartMove;
	public static Action deathcount;
	public static int deaths = 0;

	public Text Deathtext;
	public bool doit = true;
	public static Action Recenter;
	


	void OnTriggerEnter(Collider TheCollision){

		if(TheCollision.tag == "Player" && doit == true){
				doit = false;
			Invoke("Startagain", 0);
			

			}
		
	}

	void Startagain (){
				player.transform.position = SpawnPoint.transform.position;
				Recenter();
				deaths++;
				Invoke("heydeadman", 1);

				// deathtext.text = "deaths: " + DestroyScript.berry;
				// StartMove();
	}
				void heydeadman (){
					Deathtext.text = "Deaths: " + RespawnScript.deaths;
					doit = true;
				}

}
