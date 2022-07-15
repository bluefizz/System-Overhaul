using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    [SerializeField]
    private GameObject aimImage;
    public GameObject player;
    public bool open;
    public GameObject UpgradePanels;
    public Text pressF;

    public Vector3 Offset;
    public Vector3 Offset2;

    // Start is called before the first frame update
    void Start()
    {
        pressF.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CanvasController();
        OpenPanel();
    }

    void CanvasController()
    {
        pressF.transform.position = (Offset + transform.position);
    }

    public void OpenPanel()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 6f)
        {
            pressF.gameObject.SetActive(true);

            if ((Input.GetKeyDown(KeyCode.F)))
            {
                open = !open;

                if (open == true)
                {
                    aimImage.gameObject.SetActive(false);
                    UpgradePanels.SetActive(true);
                    Cursor.lockState = CursorLockMode.Confined;
                    Time.timeScale = 0;
                }
                else
                {
                    aimImage.gameObject.SetActive(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    UpgradePanels.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
        else
        {
            pressF.gameObject.SetActive(false);
        }
    }
}
