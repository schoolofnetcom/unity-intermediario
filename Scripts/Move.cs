using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    private Rigidbody rb;
	public float velocidade = 4.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float posicaoHorizontal = Input.GetAxis ("Horizontal");
		float posicaoVertical = Input.GetAxis ("Vertical");

		Vector3 movimento = new Vector3 (posicaoHorizontal,0.0f,posicaoVertical);

		rb.AddForce (movimento*velocidade);
	}
}
