using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);

        childTransform.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));

        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));

    }

    
    void Update()
    {
        
    }
}
