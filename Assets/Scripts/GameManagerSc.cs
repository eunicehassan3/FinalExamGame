
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerSc : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public Button restartButton;
    public GameObject[] enemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  GameOver(bool won){
        if(won == true){
            resultText.text = "YOU WON!";
        }
        else{
            resultText.text = "GAME OVER";
        }
    }


    public void restartGame(){
        SceneManager.LoadScene("gameplay");
        SpawnEnemy();
    }

    public void SpawnEnemy(){
        GameObject enemy;
        int num = Random.Range(0, 100);
        if(num < 50){
            enemy = enemies[0];
        }
        else{
            enemy = enemies[1];
        }

       Instantiate(enemy, new Vector3(4,-0.5f,0f), enemies[0].gameObject.transform.rotation);
       enemy.SetActive(true);
    }
}
