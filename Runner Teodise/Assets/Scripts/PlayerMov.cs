using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{

    public float forwardForce1 = 2000f;

    public float sidewaysForce1 = 500f;

    public Vector3 position;

    public Rigidbody rb3;

    public TextMeshProUGUI oran2;
    public TextMeshProUGUI para2;


    void FixedUpdate()
    {
        rb3.AddForce(0, 0, forwardForce1 * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb3.AddForce(sidewaysForce1 * 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb3.AddForce(-sidewaysForce1 * 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb3.position.y < -3f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //FindObjectOfType<GameManager>().EndGame();
            gameObject.transform.position = position;
            PlayerTrigger fall = gameObject.GetComponent<PlayerTrigger>();
            fall.currentOy = 35;
            fall.currentMoney = 140000;
            Debug.Log(fall.currentOy + " " + fall.currentMoney );
            oran2.SetText(fall.currentOy.ToString());
            para2.SetText(fall.currentMoney.ToString());
        }

    }
}
