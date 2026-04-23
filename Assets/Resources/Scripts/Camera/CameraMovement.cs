using System;
using Unity.Mathematics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] Transform playerTrans;

    void Update()
    {
        cameraTarget.position = new Vector2(playerTrans.position.x + 7 , cameraTarget.position.y);
    }

}
