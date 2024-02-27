using UnityEngine;

namespace CodeBase.Logic
{
    public class LookAtCamera : MonoBehaviour
    {
        private void Awake()
        {
            Camera mainCamera = Camera.main;

            if (mainCamera != null) 
                transform.LookAt(mainCamera.transform);
        }
    }
}