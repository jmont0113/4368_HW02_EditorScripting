using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    private Vector3 scaleChange;
    private Vector3 positionChange;

    void Start()
    {
        ChangeSize();
        ResetPosition();
    }

    public void ChangeSize()
    {
        scaleChange = new Vector3(5f, 5f, 5f);
        transform.localScale = scaleChange;
    }

    public void ResetSize()
    {
        scaleChange = new Vector3(1f, 1f, 1f);
        transform.localScale = scaleChange;
    }

    public void ChangePosition()
    {
        positionChange = new Vector3(-1f, 3f, 8f);
        transform.localPosition = positionChange;
    }

    public void ResetPosition()
    {
        positionChange = new Vector3(1f, -3f, -8f);
        transform.localPosition = positionChange;
    }
}
