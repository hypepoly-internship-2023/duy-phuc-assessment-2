using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnMouseDrag()
    {
        //if(!GameManager.instance.isHover) { return; }
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, GameManager.instance.zDistanceCamera);
        Vector3 worldPos = GameManager.instance.cam.ScreenToWorldPoint(screenPos);
        transform.position = new Vector3(worldPos.x, 0.5f, worldPos.y);
    }
}
