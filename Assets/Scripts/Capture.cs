using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Capture : MonoBehaviour {
    public Text scoreText;
    private int score = 0;
    public Camera cam;
    
    public static bool playerWins = false;
    public Text tiempoInicio;
    public Text tiempoTotal;
    
    private float tiempo = 3.0f;
    private float tiempoTota = 150.0f;
    

    // Update is called once per frame
    void Update()
    {
       if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            tiempoInicio.text = "" + tiempo.ToString("f0");
          //  agent.enabled = false;
            tiempoInicio.enabled = true;
        }
        else
        {
          //  agent.enabled = true;
            tiempoInicio.enabled = false;
            tiempoTota -= Time.deltaTime;
            tiempoTotal.text = "Tiempo: 00" + tiempoTota.ToString("f0");
        }

        if (scoreText) {
            scoreText.text = "Capturated people: " + score.ToString() + "/10";
        }

        if (Input.GetMouseButtonDown(0)) {
            Ray myRay = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if (Physics.Raycast(myRay, out RaycastHit hitInfo)) {
                if (hitInfo.collider.CompareTag("Destroy")) {
                    Destroy(hitInfo.collider.gameObject);
                    score++;
                }
            }

        }
        if(tiempoTota==150){
            if(score==10){
                playerWins = true;
                SceneManager.LoadScene("Winner");
            }
          
        }
        else{
            if(score<10){
                playerWins = false;
                SceneManager.LoadScene("Lose");
            }
        }

    }

    private void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f) {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Standard"));
        lr.startColor = color;
        lr.endColor = color;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        GameObject.Destroy(myLine, duration);
    }
}
