using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentosPlayer : MonoBehaviour
{
    public float speed;
    public int movimentoVertical = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Mov();
        if (Input.GetButtonDown("Vertical"))
        {
           
        }
    }
    private void Mov()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
    }
}
