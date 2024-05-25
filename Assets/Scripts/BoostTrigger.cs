using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
    public float boostForce = 10f; // Сила подкидывания

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("boost"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * boostForce, ForceMode.Impulse); // Подкидываем объект вверх с использованием импульса
            }
        }
    }
}
