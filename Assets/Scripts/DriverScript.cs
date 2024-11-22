using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DriverScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    private bool accelePressed = false;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (accelePressed == true)
        {
            m_Rigidbody.AddForce(transform.forward * m_Thrust);
        }
    }
    
    public void Accelerate()
    {
        accelePressed = true;
    }
    
}
