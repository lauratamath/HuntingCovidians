using UnityEngine;
using UnityEngine.UI;

public class CapureIt : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
 
    // Update is called once per frame
    void Update()
    {
        if (scoreText)
            scoreText.text = "Capturated people: " + score.ToString() + "/10";

        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Destroy"))
                {
                    Destroy(hitInfo.collider.gameObject);
                    score++;
                }
            }


        }

    }
}
