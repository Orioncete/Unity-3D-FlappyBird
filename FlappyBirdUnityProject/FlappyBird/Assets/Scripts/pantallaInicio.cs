using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pantallaInicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("scene1");
        }

    }
}
