using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translatePoint : MonoBehaviour
{
    void Update()
    {
        float Horz = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(Vert * 5 * Time.deltaTime, 0, Horz * -5 * Time.deltaTime);

    }
}
