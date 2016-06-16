using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textoPuntuacion : MonoBehaviour {
    private Text displayPuntos;
    private int puntos;

	// Use this for initialization
	void Start () {
        this.puntos = main.puntuacion;
        this.displayPuntos = this.gameObject.GetComponent<Text>();
        this.displayPuntos.text = "Puntuación: " + puntos;
    }
	
	// Update is called once per frame
	void Update () {
        this.puntos = main.puntuacion;
        this.displayPuntos = this.gameObject.GetComponent<Text>();
        this.displayPuntos.text = "Puntuación: " + puntos;
    }
}
