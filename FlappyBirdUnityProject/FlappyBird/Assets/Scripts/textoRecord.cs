using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textoRecord : MonoBehaviour {
    private Text displayRecord;
    private int record;

    // Use this for initialization
    void Start()
    {
        this.record = main.record;
        this.displayRecord = this.gameObject.GetComponent<Text>();
        this.displayRecord.text = "Record: " + record;
    }

    // Update is called once per frame
    void Update()
    {   
        if (main.puntuacion >= main.record)
        {
            main.record = main.puntuacion;
            PlayerPrefs.SetInt("record", main.record);
        }
        this.record = main.record;
        this.displayRecord = this.gameObject.GetComponent<Text>();
        this.displayRecord.text = "Record: " + record;
    }
}
