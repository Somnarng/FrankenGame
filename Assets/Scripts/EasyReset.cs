using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class EasyReset : MonoBehaviour
{
    public GameObject player;
    private Vector3 defaultPos;
    private void Start()
    {
        defaultPos = player.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ResetPlayer();
    }
    private void ResetPlayer()
    {
        player.transform.position = defaultPos;
    }
}
