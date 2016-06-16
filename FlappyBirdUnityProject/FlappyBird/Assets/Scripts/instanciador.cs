using UnityEngine;
using System.Collections;

public class instanciador : MonoBehaviour {
    public float frecuencia;
    private float momento;
    public GameObject tuberia;

	// Use this for initialization
	void Start () {
        main.frecuencia = this.frecuencia;
        this.momento = Time.time + main.frecuencia;
	}
	
	// Update is called once per frame
	void Update () {
	    if (this.momento <= Time.time && main.animacion == true)
        {
            main.frecuencia = this.frecuencia / main.dificultad;
            this.momento = Time.time + main.frecuencia;
            Instantiate(this.tuberia, new Vector3(this.transform.position.x, Random.Range(-3.5f, 3.2f), this.transform.position.z), this.transform.rotation);
        }
	}
}
