using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 0.01f; // 감도 조절
    public float rotationX;
    public float rotationY;

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");
        float mouseMoveY = Input.GetAxis("Mouse Y");

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        rotationX += mouseMoveY * sensitivity * Time.deltaTime; // Y축 반전 처리

        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // 상하 각도 제한 (좌우 제한 제거)

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
