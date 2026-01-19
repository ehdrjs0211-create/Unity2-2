using UnityEngine;
using UnityEngine.UI;

public class Gandler : MonoBehaviour
{
    [SerializeField] Button pauseButton;

    private void Awake()
    {
        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener(GameManager.Instance.Pause);
    }
}
