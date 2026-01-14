using UnityEngine;

public class Chillick : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 minScale = new Vector3(1, 1, 1);
    [SerializeField] Vector3 maxScale = new Vector3(2, 2, 2);
   
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1.0f);

        transform.localScale = minScale + (maxScale - minScale) * time;
    }
}
