using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject gameObject;
    private Vector3 toForward = new Vector3(0, 5, -7);
    private Vector3 toBack = new Vector3(0, 5, -11);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position = gameObject.transform.position + new Vector3(0, 5, -7 + Input.GetAxis("Vertical")*2);
            return;
        }
        transform.position = gameObject.transform.position + toForward;
    }
}
