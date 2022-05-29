using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    [SerializeField] GameObject canvasToHide;

    public void HideUIOnClick()
    {
        if (canvasToHide.activeSelf) canvasToHide.SetActive(false);
        else canvasToHide.SetActive(true);
    }
}
