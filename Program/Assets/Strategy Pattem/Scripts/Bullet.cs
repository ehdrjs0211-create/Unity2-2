using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float duration;
    [SerializeField] Vector3 direction;

    void Start()
    {
        Destroy(gameObject, duration);   
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);    
    }
}
