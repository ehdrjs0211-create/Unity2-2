using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    [SerializeField] bool state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    public void Pause()
    {
        state = false;
    }
}
