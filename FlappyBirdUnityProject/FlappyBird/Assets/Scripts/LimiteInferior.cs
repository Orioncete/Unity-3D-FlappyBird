using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LimiteInferior : MonoBehaviour {

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
            PlayerPrefs.SetInt("record", main.record);
            PlayerPrefs.SetFloat("velocidad", main.velocidad);
            PlayerPrefs.SetFloat("fuerza", main.fuerza);
            PlayerPrefs.SetFloat("frecuencia", main.frecuencia);
            Destroy(other.gameObject);
            main.puntuacion = 0;
            SceneManager.LoadScene("intro");
        }
    }
}
