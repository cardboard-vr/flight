using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flightController : MonoBehaviour {

    public Text VRScoreTxt;
    public int score;

    private float speed;

	// Use this for initialization
	void Start () {
        VRScoreTxt.text = "Score: 0";
        score = 0;
        speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
        // Logistic-Growth y-to-speed mapping
        float yPos = transform.position.y;
        speed = (50 / (1 + (Mathf.Exp(-0.07f * (yPos - 40.0f))))) + 10.0f;
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            PickupRespawner pr = (PickupRespawner) other.gameObject.GetComponent(typeof(PickupRespawner));
            pr.collect();
            score++;
            VRScoreTxt.text = "Score: " + score;
        }
    }
}
