using UnityEngine;
using System.Collections;

public class starter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        main.record = PlayerPrefs.GetInt("record");
        main.velocidad = PlayerPrefs.GetFloat("velocidad");
        main.fuerza = PlayerPrefs.GetFloat("fuerza");
        main.frecuencia = PlayerPrefs.GetFloat("frecuencia");
        main.dificultad = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
