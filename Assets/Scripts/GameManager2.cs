using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public Text playerscoretext;

    public Text computerscoretext;

    private int _playerScore;

    public Ball ball;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        playerscoretext.text = _playerScore.ToString();
        this.ball.ResetPosition();
        Debug.Log(_playerScore);
        if (_playerScore == 5)
        {
            SceneManager.LoadScene("Player1Wins");
        }
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerscoretext.text = _computerScore.ToString();
        this.ball.ResetPosition();
        Debug.Log(_computerScore);
        if (_computerScore == 5)
        {
            SceneManager.LoadScene("Player2Wins");
        }
    }
}
