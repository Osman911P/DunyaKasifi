using UnityEngine;

public class ModelClickHandler : MonoBehaviour
{
    public GameObject infoPanel;
    private Camera arCamera;

    void Start()
    {
        arCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform) // Bu objeye tıklanmışsa
                {
                    if (infoPanel != null)
                    {
                        infoPanel.SetActive(!infoPanel.activeSelf);
                    }
                }
            }
        }
    }
}
