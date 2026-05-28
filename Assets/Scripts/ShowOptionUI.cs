using UnityEngine;

public class ShowOptionUI : MonoBehaviour
{
    public GameObject optionPanel;

    private bool hasShown = false;

    private void Start()
    {
        optionPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasShown)
        {
            optionPanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            hasShown = true;
        }
    }
}