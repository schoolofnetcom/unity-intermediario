using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linear : MonoBehaviour {
    
    private CharacterController ControllerObjeto;
	public float velocidade = 10.0f;
	// Use this for initialization
	void Start () {
		ControllerObjeto = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
    
		ControllerObjeto.Move(Vector3.forward * velocidade * Time.deltaTime);
	  
	}
}
