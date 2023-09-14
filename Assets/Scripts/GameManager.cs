using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject spikes;
    public void Click()
    {
        spikes.transform.position -= new Vector3(0, 0.1f, 0);
    }
}
