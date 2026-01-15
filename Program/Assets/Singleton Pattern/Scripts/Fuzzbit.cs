using UnityEngine;

public class Fuzzbit : MonoBehaviour
{
    [SerializeField] Vector3 axis;
    [SerializeField] float angle = 45f;
    [SerializeField] float speed = 1.0f;

    Quaternion quaternion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quaternion = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.State == false) return;
       
        float time = Mathf.PingPong(Time.time * speed, 1f);

        float value = (time * 2f - 1f) * angle;

        transform.localRotation = quaternion * Quaternion.AngleAxis(value, axis);
    }
}
