using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesControl : MonoBehaviour
{
    private float defaultY;
    public GameObject resetPos;
    void Start()
    {
        defaultY = transform.position.y;   
    }

    void Update()
    {
        if (transform.position.y < defaultY)
        {
            transform.position += new Vector3(0, Time.deltaTime/4, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = resetPos.transform.position;
    }
}
