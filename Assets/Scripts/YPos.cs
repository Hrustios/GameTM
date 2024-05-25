using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YPos : MonoBehaviour
{
    public class ResetOnFall : MonoBehaviour
    {
        public Transform targetTransform; // Пустышка, к которой будет возвращаться объект

        private void Update()
        {
            if (transform.position.y < -3f)
            {
                // Возвращаем объект к пустышке
                if (targetTransform != null)
                {
                    transform.position = targetTransform.position;
                }
            }
        }
    }
}
