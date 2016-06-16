using UnityEngine;
using System.Collections;

public class sumaPuntos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "birdCounter")
        {
            main.puntuacion += 1;
            if (main.puntuacion % 5 == 0)
            {
                main.dificultad = 1.0f + (main.puntuacion / 20.0f);
            }
        }
    }
}
