using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public CanvasGroup endCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        endCanvas.alpha = 1;
    }
}