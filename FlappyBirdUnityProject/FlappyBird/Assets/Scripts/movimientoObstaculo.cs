using UnityEngine;
using System.Collections;

public class movimientoObstaculo : MonoBehaviour {
    public float velocidad;

	// Use this for initialization
	void Start () {
        main.velocidad = this.velocidad;
	}
	
	// Update is called once per frame
	void Update () {
  
        this.transform.Translate(-Vector3.right * main.velocidad * main.dificultad * Time.deltaTime);
	
	}
    
}
