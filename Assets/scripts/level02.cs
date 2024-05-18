using UnityEngine;
using UnityEngine.UI;  // Include this if you're working with UI elements

public class Level02 : MonoBehaviour
{
    public Text uiText;  // Reference to the UI Text element

    private void Start()
    {
        if (uiText != null)
        {
            uiText.gameObject.SetActive(false);  // Ensure the text is hidden at the start
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // Assuming the player has the tag "Player"
        {
            if (uiText != null)
            {
                uiText.gameObject.SetActive(true);  // Show the text when the player hits the collider
            }
        }
    }
}
