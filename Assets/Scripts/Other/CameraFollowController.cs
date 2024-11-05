using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] [Range(1,3)] private float LerpTime;
    private float bollYPosition;

    private Vector3 ofset;
    private Vector3 newPos;
    void Start()
    {
        ofset = transform.position - ballTransform.position;
        bollYPosition = ballTransform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraPositon();
    }

    private void SetCameraPositon()
    {
        newPos = Vector3.Lerp(transform.position, new Vector3(ballTransform.position.x, bollYPosition, ballTransform.position.z) + ofset,LerpTime * Time.deltaTime);
        transform.position = newPos;
    }
}
