using UnityEngine;

public class Berrion : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float distance = 2.0f;
    [SerializeField] Vector3 direction = Vector3.right;

    [SerializeField] Vector3 initializePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initializePosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.State == false) return;
        float time = Mathf.PingPong(Time.time * speed, 1f);
        transform.localPosition = initializePosition + direction.normalized * time;
    }
}
