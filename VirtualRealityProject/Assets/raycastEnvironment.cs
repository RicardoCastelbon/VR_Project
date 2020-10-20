using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class raycastEnvironment : MonoBehaviour {

    private float contador = 0;

    public GameObject canvasOffice;
    public GameObject canvasBack;

    public GameObject chargeOffice;
    public GameObject chargeBack;

    public GameObject scriptManager;

    public manager controladorManager;

    public Material whiteSkybox;
    public Material officeSkybox;

    public GameObject bottonOffice;
    public GameObject bottonnature;
    public GameObject bottontransport;
    public GameObject bottonHome;
    public GameObject bottonSchool;

    // Use this for initialization
    void Start () {

        scriptManager = GameObject.Find("ManagerScript");

        controladorManager = GameObject.Find("ManagerScript").GetComponent<manager>();


    }

    // Update is called once per frame
    void Update ()
    {
        

        RaycastHit hitMenu;
        Vector3 forwardMenu = transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(transform.position, forwardMenu, Color.blue);

        if (Physics.Raycast(transform.position, forwardMenu, out hitMenu))
        {
            //CANVASOFFICE.................................

            if (hitMenu.transform.gameObject == canvasOffice)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasOffice.transform.localScale = Vector3.Slerp(canvasOffice.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeOffice.transform.localScale = Vector3.Slerp(chargeOffice.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);

                RenderSettings.skybox = officeSkybox;

            }
            else
            {
                canvasOffice.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
                chargeOffice.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }

            //RETURN.................................

            if (hitMenu.transform.gameObject == canvasBack)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasBack.transform.localScale = Vector3.Slerp(canvasBack.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeBack.transform.localScale = Vector3.Slerp(chargeBack.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);

            }
            else
            {
                canvasBack.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
                chargeBack.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }
        }
        else
        {
            canvasOffice.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeOffice.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);

            canvasBack.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeBack.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);

            contador = 0;

            RenderSettings.skybox = whiteSkybox;

        }

        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasOffice))
        {
            SceneManager.LoadScene(2);
        }
        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasBack))
        {
            Destroy(scriptManager);
            SceneManager.LoadScene(0);
        }
    }

    }

