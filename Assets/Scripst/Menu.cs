using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaPrincipal;
    [SerializeField]
    GameObject pantallaObjetos;
    
    void Start()
    {
        pantallaPrincipal.SetActive(true);
        pantallaObjetos.SetActive(false);
    }

    // Update is called once per frame
    public void PantallaActivadaObjetos()
    {
        pantallaPrincipal.SetActive(false);
        pantallaObjetos.SetActive(true);
    }
    public void PantallaDesactivadaObjetos()
    {
        pantallaPrincipal.SetActive(true);
        pantallaObjetos.SetActive(false);
    }
}
