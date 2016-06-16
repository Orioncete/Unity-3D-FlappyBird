using UnityEngine;
using System.Collections;

public class movimientoPajaro : MonoBehaviour {
    public float fuerza;

	// Use this for initialization
	void Start () {
        main.fuerza = this.fuerza;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponentInChildren<Rigidbody>().AddForce(this.transform.up * main.fuerza);
        }
	}
}
