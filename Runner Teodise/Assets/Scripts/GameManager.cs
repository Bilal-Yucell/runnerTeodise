using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    BoxCollider coll2;

    public GameObject choice01, choice02, choice03, choice04, choice05, choice06,
            choice07, choice08, choice09, choice10, choice11, choice12, choice13,
            choice14, choice15, choice16, choice17, choice18;

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject failedLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        
    }

    public void FailedLevelUI()
    {
        failedLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
}
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*
        coll2 = choice01.GetComponent<BoxCollider>();
        coll2.enabled = true;
        coll2 = choice02.GetComponent<BoxCollider>();
        coll2.enabled = true;
        coll2 = choice03.GetComponent<BoxCollider>();
        coll2.enabled = true;
        coll2 = choice04.GetComponent<BoxCollider>();
        coll2.enabled = true;
        */

        //FindObjectOfType<PlayerTrigger>();
        //GameObject obje = GameObject.Find("Choice03");
        //obje.
        
    }

}
