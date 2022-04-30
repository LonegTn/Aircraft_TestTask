using UnityEngine;

/// <summary>
/// Триггер уничтожения объектов
/// </summary>
public class DestroyTrigger : MonoBehaviour
{
    [SerializeField] private Vector3 offset;

    private void Awake()
    {
        transform.localPosition = new Vector3(0, Screen.height, 0) + offset;
        transform.localScale = new Vector3(Screen.width, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Component hittableComponent = collision.GetComponent(typeof(IHittable));
        IHittable hittableObject = hittableComponent != null ? (IHittable)hittableComponent : null;

        if (hittableObject != null)
        {
            hittableObject.Hit();
        }
    }
}