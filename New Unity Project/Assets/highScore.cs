using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour{
    
    public Transform player;
    public Text scoreText;
    public Text scoreText2;

    void Update()
    {
        scoreText.text = "$" + (250+(-1)*player.position.z).ToString("0");
        scoreText2.text = "You've made "+"$" + (250+(-1)*player.position.z).ToString("0") + "\nYou can use the money to\n donate to TeamTrees.org";
    }
}
