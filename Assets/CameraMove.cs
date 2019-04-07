using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    GameObject playerObj;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
         playerObj = GameObject.Find("Tiger");
         offset = new Vector3(12,9,5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position + offset;
    }
}
