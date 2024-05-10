using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_joystick : MonoBehaviour
{
    public GameObject jsFather;
    public FixedJoystick joystick;
    public Toggle toggle;
    public GameObject ball;
    public Rigidbody rb;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick != null)
        {
            if (joystick.Horizontal != 0)
            {
                ball.transform.position += Vector3.right * joystick.Horizontal * speed * Time.deltaTime;
            }
            if (joystick.Vertical != 0)
            {
                ball.transform.position += Vector3.up * joystick.Vertical * speed * Time.deltaTime;
            }
        }
    }

    public void turnOnJoystick()
    {
        if (!toggle.isOn)
        {
            jsFather.SetActive(false);
            rb.useGravity = true;
        }
        else
        {
            jsFather.SetActive(true);
            rb.useGravity = false;
        }
    }

}
