using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFolow : MonoBehaviour
{
    public Transform cube;
    private float MinDistance = 0.8f;
    private float distance = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (cube != null)
        {
            this.transform.LookAt(cube);
            if (Vector3.Distance(this.transform.position, cube.position) > MinDistance)
            {
                this.transform.Translate(0f, 0f, distance * Time.deltaTime);
            }
        }
    }
}
