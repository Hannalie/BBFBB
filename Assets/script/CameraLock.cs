using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraLock : MonoBehaviour
{
    // [SerializeField] private Transform cameraCoordinatesTransform;
    [SerializeField] private GameObject m_Camera, cameraCoordinates;
    // private bool activateThisScene = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            CameraFollow.cameraLock = true;
            /*
            Vector3 newposition = Vector3.Lerp(m_Camera.transform.position, cameraCoordinatesTransform.position, 1);
            transform.position = newposition; */
            m_Camera.transform.position = cameraCoordinates.transform.position;
        }

        /*
        void LateUpdate()
        {
            if (activateThisScene == true)
            {
                Vector3 newposition = Vector3.Lerp(m_Camera.transform.position, cameraCoordinatesTransform.position, 1);
                transform.position = newposition;
            }
        } */
    }

}
