using UnityEngine;
using System.Collections;

public class Tuberia : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "bird")
        {
            main.velocidad = 0.0f;
            main.fuerza = 0.0f;
            main.animacion = false;
        }
    }
}
