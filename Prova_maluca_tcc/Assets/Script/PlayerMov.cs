using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public float forcaPulo;
    private float MovZ;
    private float MovX;
    Rigidbody rbPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovZ = Input.GetAxisRaw("Vertical");
        MovX = Input.GetAxisRaw("Horizontal");
        andar();
        pular();
    }
    private void pular()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbPlayer.AddForce(0,forcaPulo,0);
        }
    }
    private void andar()
    {
        
        if(Input.GetButton("Vertical"))
        {
            rbPlayer.AddForce(0,0,0.3f*MovZ,ForceMode.Impulse);
        }
        if (Input.GetButton("Horizontal"))
        {
            rbPlayer.AddForce(0.3f * MovX, 0, 0, ForceMode.Impulse);
        }

    }
}
