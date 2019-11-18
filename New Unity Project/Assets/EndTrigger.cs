using UnityEngine;

public class EndTrigger : MonoBehaviour{

    public gameManager gm;

    void OnTriggerEnter() {
        gm.CompleteLevel();
    }
}
