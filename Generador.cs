using UnityEngine;
using System.Collections;


public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1.25f;
	public float tiempoMax = 2.5f;
    Random rand = new Random();

    float x;
    float y;
    float z;
    Vector3 pos;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;
    

    // Use this for initialization
    void Start () {

        

        

        Generar();

    }

	
	
	// Update is called once per frame
	void Update () {
        
        x = Random.Range(-3.5f, 4.8f);
        y = Random.Range(-3, 0.5f);
        z = 0;

        float x2 = Random.Range(-11f, -2f);
        float y2 = Random.Range(0f, 6f);
        float x3 = Random.Range(2.89f, 11f);
        float y3 = Random.Range(0.5f, 6.6f);
        float x4 = Random.Range(-1.43f, 2.39f);
        float y4 = Random.Range(2.86f, 6.6f);

        pos = new Vector3(x, y, z);
        pos2 = new Vector3(x2, y2, z);
        pos3 = new Vector3(x3, y3, z);
        pos4 = new Vector3(x4, y4, z);

        

        

        int w = Random.Range(0, 3);

        if (w == 0)
        {
            transform.position = pos;
        }
        if (w == 1)
        {
            transform.position = pos2;
        }
        if (w == 2)
        {
            transform.position = pos3;
        }
        if (w == 3)
        {
            transform.position = pos4;
        }



    }

	void Generar(){
		Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
	}
}
