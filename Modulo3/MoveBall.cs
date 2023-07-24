using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) transform.position += Vector3.right * 2.5f * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow)) transform.position += Vector3.left * 2.5f * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)) transform.position += Vector3.forward * 2.5f * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) transform.position += Vector3.back * 2.5f * Time.deltaTime;
    }
}
