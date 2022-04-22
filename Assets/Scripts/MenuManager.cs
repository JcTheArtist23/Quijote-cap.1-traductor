using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   public Text parrafo1;
   public Text parrafo2;
   public Text parrafo3;
   public Text parrafo4;
   public ScriptableTraductions español;
   public ScriptableTraductions ingles;
   public ScriptableTraductions chino;
   public ScriptableTraductions japones;

    public void TraducirEspañol()
    {
        parrafo1.text= español.text1;
        parrafo2.text= español.text2;
        parrafo3.text= español.text3;
        parrafo4.text= español.text4;
    }

     public void TraducirIngles()
    {
        parrafo1.text= ingles.text1;
        parrafo2.text= ingles.text2;
        parrafo3.text= ingles.text3;
        parrafo4.text= ingles.text4;
    }
     public void TraducirChino()
    {
        parrafo1.text= chino.text1;
        parrafo2.text= chino.text2;
        parrafo3.text= chino.text3;
        parrafo4.text= chino.text4;
    }
     public void TraducirJapones()
    {
        parrafo1.text= japones.text1;
        parrafo2.text= japones.text2;
        parrafo3.text= japones.text3;
        parrafo4.text= japones.text4;
    }
}
