using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Handle the cirular world using camera borders
*/
public class CircleWorldCamera : MonoBehaviour
{
    private Camera camera;

    private float cameraLeftBorder;

    private float cameraRightBorder;

    private float cameraTopBorder;

    private float cameraBottomBorder;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;

        cameraRightBorder = camera.aspect * camera.orthographicSize;
        cameraLeftBorder = -cameraRightBorder;

        cameraTopBorder = camera.orthographicSize;
        cameraBottomBorder = -cameraTopBorder;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;


        if (posX >= cameraRightBorder && horizontal > 0)
        {
            Debug.Log("right border");
            transform.position = new Vector3(cameraLeftBorder, posY, posZ);
        }

        if (posX <= cameraLeftBorder && horizontal < 0)
        {
            Debug.Log("left border");
            transform.position = new Vector3(cameraRightBorder, posY, posZ);
        }

        if (posY >= cameraTopBorder && vertical > 0)
        {
            Debug.Log("top border");
            transform.position = new Vector3(posX, cameraBottomBorder, posZ);
        }

        if (posY <= cameraBottomBorder && vertical < 0)
        {
            Debug.Log("bottom border");
            transform.position = new Vector3(posX, cameraTopBorder, posZ);
        }
    }
}
