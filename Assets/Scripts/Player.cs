using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController playerController;
    private float movFrenteTras;
    private float movDireitaEsquerda;

    private float velocidade;

    private float velocidadePulo;

    public float gravidade;
    
    public float forcaDoPulo;

    public Vector3 direcao;

    
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        movFrenteTras = Input.GetAxis("Vertical");
        movDireitaEsquerda = Input.GetAxis("Horizontal");
        direcao = new Vector3(movDireitaEsquerda,0,movFrenteTras);
        
        if (playerController.isGrounded){
     
            if (Input.GetButtonDown("Jump"))  {

            direcao.y = forcaDoPulo;

            }

        }
       
        direcao.y -= gravidade * Time.deltaTime;
        playerController.Move(  direcao * Time.deltaTime * velocidade );
    }
}


