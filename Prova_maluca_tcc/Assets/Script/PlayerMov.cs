using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public float forcaPulo;
    Rigidbody rbPlayer;
    public bool checkPulo;
   
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            if (checkPulo == true)
            {
                andar();
            }
            
        }
        
        pular();

    }
    private void pular()
    {
        if (Input.GetKeyDown(KeyCode.Space) && checkPulo == true)
        {
            checkPulo = false;
            rbPlayer.velocity = new Vector3(rbPlayer.velocity.x, 0, rbPlayer.velocity.z); 
            rbPlayer.AddForce(0,forcaPulo,0);
            
        }
    }
    private void andar()
    {

        rbPlayer.velocity = new Vector3(Input.GetAxisRaw("Horizontal")*speed,rbPlayer.velocity.y ,Input.GetAxisRaw("Vertical")*speed);

    }

    private void OnCollisionStay(Collision collision)
    {

        checkPulo = true;

    }
}
