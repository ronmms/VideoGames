using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int helath = 100;
    public Text enemyText;
    public static int enemys = 4;
    private GameManager gm = GameManager.Instance;

    private void Start() {
        enemyText = GameObject.Find("Canvas/EnemysLeft").GetComponent<Text>();
        enemyText.text = "Enemys Left: " + enemys;
    }
    public void takeDamage(int damage)
    {
        helath -= damage;

        if (helath <= 0)
        {
            die();
        }

    }

    private void die()
    {
        Destroy(this.gameObject);
        enemys--;
        enemyText.text = "Enemys Left: " + enemys;
        isWin();

    }

    private void isWin()
    {
        if(enemys == 0)
        {
            gm.updateGameState(GameState.Victory);
        }
    }

}
