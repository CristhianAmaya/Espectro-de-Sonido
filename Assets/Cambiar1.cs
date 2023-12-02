using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiar1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Furelise(){ //Fur Elise
        SceneManager.LoadScene("FurElise");
    }
    public void BS(){ //Cambia a la canción Battle Symphony
        SceneManager.LoadScene("BattleSymphony");
    }
    public void ByTheWay(){ //Cambia a la canción By The Way
        SceneManager.LoadScene("ByTheWay");
    }
    public void OtherSide(){ //Cambia a la canción otherside
        SceneManager.LoadScene("OtherSide");
    }
    public void AmericanIdiot(){ //Cambia a la canción American Idiot
        SceneManager.LoadScene("AmericanIdiot");
    }
}
