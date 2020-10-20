using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class raycastLanguage : MonoBehaviour {

    public manager controladorManager;

    public GameObject canvasEnglish;
    public GameObject canvasSvenska;
    public GameObject canvasEspanol;
    public GameObject canvasArabe;
    public GameObject canvasDeutsch;
    public GameObject canvasExitApp;

    public GameObject chargeEnglish;
    public GameObject chargeSwedish;
    public GameObject chargeEspanol;
    public GameObject chargeArabic;
    public GameObject chargeExitApp;

    private float contador = 0;

    // Use this for initialization
    void Start () {

       
	
	}
	
	// Update is called once per frame
	void Update () {

       

        RaycastHit hitMenu;
        


        Vector3 forwardMenu = transform.TransformDirection(Vector3.forward) * 10;


        Debug.DrawRay(transform.position, forwardMenu, Color.blue);

        if (Physics.Raycast(transform.position, forwardMenu, out hitMenu))
        {
            //ENGLISH.................................

            if (hitMenu.transform.gameObject == canvasEnglish)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasEnglish.transform.localScale = Vector3.Slerp(canvasEnglish.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeEnglish.transform.localScale = Vector3.Slerp(chargeEnglish.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);

            }
            else
            {
                canvasEnglish.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
                chargeEnglish.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }

            //SWEDISH..............................

            if (hitMenu.transform.gameObject == canvasSvenska)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasSvenska.transform.localScale = Vector3.Slerp(canvasSvenska.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeSwedish.transform.localScale = Vector3.Slerp(chargeSwedish.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);
            }
            else
            {
                canvasSvenska.transform.localScale = new Vector3(0.003f, 0.003f, 0.0023f);
                chargeSwedish.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }
            //SPANISH..............................

            if (hitMenu.transform.gameObject == canvasEspanol)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasEspanol.transform.localScale = Vector3.Slerp(canvasEspanol.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeEspanol.transform.localScale = Vector3.Slerp(chargeEspanol.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);
            }
            else
            {
                canvasEspanol.transform.localScale = new Vector3(0.003f, 0.003f, 0.0023f);
                chargeEspanol.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }
            //ARABIC..............................

            if (hitMenu.transform.gameObject == canvasArabe)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasArabe.transform.localScale = Vector3.Slerp(canvasArabe.transform.localScale, new Vector3(0.0035f, 0.0035f, 0.0f), Time.deltaTime * 7.0f);
                chargeArabic.transform.localScale = Vector3.Slerp(chargeArabic.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);
            }
            else
            {
                canvasArabe.transform.localScale = new Vector3(0.003f, 0.003f, 0.0023f);
                chargeArabic.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }

            //EXIT APP............................

            if (hitMenu.transform.gameObject == canvasExitApp)
            {
                contador += Time.deltaTime;
                Debug.Log(contador);

                canvasExitApp.transform.localScale = Vector3.Slerp(canvasExitApp.transform.localScale, new Vector3(1.1f, 1.1f, 0.0f), Time.deltaTime * 7.0f);
                chargeExitApp.transform.localScale = Vector3.Slerp(chargeExitApp.transform.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 1.0f);

            }
            else
            {
                canvasExitApp.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
                chargeExitApp.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            }

        }
        else
        {
            canvasEnglish.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeEnglish.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            canvasEspanol.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeEspanol.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            canvasArabe.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeArabic.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            canvasSvenska.transform.localScale = new Vector3(0.003f, 0.003f, 0.0f);
            chargeSwedish.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            canvasExitApp.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
            chargeExitApp.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
            contador = 0;
        }

        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasEnglish))
        {
            controladorManager.Language = 0;
            SceneManager.LoadScene(1);   
        }
        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasSvenska))
        {
            controladorManager.Language = 1;
            SceneManager.LoadScene(1);
        }
        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasEspanol))
        {
            controladorManager.Language = 3;
            SceneManager.LoadScene(1);
        }
        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasArabe))
        {
            controladorManager.Language = 2;
            SceneManager.LoadScene(1);
        }
        if (contador >= 3.0f && (hitMenu.transform.gameObject == canvasExitApp))
        {
            Application.Quit();
        }

    }
}
