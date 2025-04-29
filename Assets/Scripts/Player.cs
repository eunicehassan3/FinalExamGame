using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    private float currentHealth;
    public Slider playerSlider;
    public TextMeshProUGUI resultText;
    // public GameManagerSc gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount){
        currentHealth -= amount;
        if(currentHealth <= 0){
            currentHealth = 0;
            resultText.text = "Game Over";
            // gameManager.GameOver(false);
        }

        UpdateHealthUI();
    }

    void UpdateHealthUI(){
        playerSlider.value = currentHealth;
    }
}
