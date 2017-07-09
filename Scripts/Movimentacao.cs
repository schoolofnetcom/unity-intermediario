using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movimentacao : MonoBehaviour {
     
     private Rigidbody rb;
	 private AudioSource executarSom;
     public float velocidade = 5.0f;
     public AudioClip som;
     public float alturaPulo = 20.0f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		executarSom = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		   
		  if(Input.GetKeyDown(KeyCode.Space)){
                 executarSom.playOnAwake = false;
				 executarSom.PlayOneShot(som, 0.7f);

                 rb.AddForce(new Vector3(0,alturaPulo,0), ForceMode.Impulse);

		  } 


		  float horizontal = Input.GetAxis("Horizontal");
		  float vertical = Input.GetAxis("Vertical");

          Vector3 movimento = new Vector3(horizontal,0.0f,vertical);
          
		  rb.AddForce(movimento*velocidade);
	}

	void OnTriggerEnter(Collider outroObjeto){
        if(outroObjeto.gameObject.name == "Armadilha" ){
           SceneManager.LoadScene("gameOver");
		}
	}
}
