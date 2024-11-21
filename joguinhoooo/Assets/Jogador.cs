using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float Vel = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovimentoHoriz = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            MovimentoHoriz = 1f;

        }
        else if(Input.GetKey(KeyCode.A))
        {
            MovimentoHoriz = -1f;
        }

        transform.position += new Vector3(MovimentoHoriz, 0f, 0f) * Vel * Time.deltaTime;

        float MovimentoVert = 0f;
        
        if(Input.GetKey(KeyCode.W)){
            MovimentoVert = 1f;
        }
        else if(Input.GetKey(KeyCode.S)){
            MovimentoVert = -1f;
        }

        transform.position += new Vector3(0f, MovimentoVert, 0f) * Vel * Time.deltaTime;

    }

}
