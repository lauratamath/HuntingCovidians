using UnityEngine;
using UnityEngine.UI;

public class Capture : MonoBehaviour {
    public Text scoreText;
    public Text debugText;
    private int score = 0;
    public Camera cam;

    private void Update() {
        if (scoreText) {
            scoreText.text = "Capturated people: " + score.ToString() + "/10";
        }

        if (Input.GetMouseButtonDown(0)) {
            //Ray myRay = cam.ScreenPointToRay(Input.mousePosition);
            //Ray myRay = new Ray(transform.position, transform.forward);
            Ray myRay = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if (Physics.Raycast(myRay, out RaycastHit hitInfo)) {
                //DrawLine(myRay.origin, hitInfo.point, Color.red, 0.5f);
                //Debug.Log(hitInfo.collider.tag + " " + hitInfo.collider.gameObject.name);
                //debugText.text = hitInfo.collider.tag + " " + hitInfo.collider.gameObject.name;
                if (hitInfo.collider.CompareTag("Destroy")) {
                    Destroy(hitInfo.collider.gameObject);
                    score++;
                }
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
