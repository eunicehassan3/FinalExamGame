using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public Slider enemySlider;

    public int attackDamage = 2;
    public float attackInterval = 0.7f;
    public bool gameOver = false;

    public GameObject player;
    // public GameManagerSc gameManager;
    public TextMeshProUGUI resultText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        InvokeRepeating("AttackPlayer", attackInterval, attackInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // StartCoroutine(AttackPlayer());
        if(Input.GetKeyDown(KeyCode.Space) && gameOver == false){
            TakeDamage(2);
        }
    }

    public void TakeDamage(int amount){
        currentHealth -= amount;
        if(currentHealth <= 0){
            currentHealth = 0;
            gameOver = true;
            resultText.text = "You Win";
        }

        UpdateHealthUI();
    }

    void AttackPlayer(){
        // yield  return new WaitForSecondsRealtime(2);
        player.GetComponent<Player>().TakeDamage(attackDamage);
    }

    void UpdateHealthUI(){
        enemySlider.value = currentHealth;
    }
}
