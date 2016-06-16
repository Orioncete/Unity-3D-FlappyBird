using UnityEngine;
using System.Collections;

public class fondoAnimado : MonoBehaviour {

	// Use this for initialization
	void Start () {
        main.animacion = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (main.animacion == false)
        {
            this.GetComponent<Animator>().Stop();
        }

        this.GetComponent<Renderer>().material.mainTextureOffset.Set(main.velocidad * main.dificultad * Time.time / 2, 0.0f);
	}
}
