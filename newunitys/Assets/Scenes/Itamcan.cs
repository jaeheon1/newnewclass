using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itamcan : MonoBehaviour
{
    public float rotateSpeed;
    
    void Update()
    {
        transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime,Space.World);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name=="Item")
        {
            PlayBall player = other.GetComponent<PlayBall>();
            player.itemCount++;
            gameObject.SetActive(false);
        }
    }
}
