using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BasicMovement : MonoBehaviour
{
    private float speed = 0.60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this != null)
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0f, 0f, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0f, 0f, speed * -1 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(speed * -1 * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
