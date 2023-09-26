using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDV_UI
{
    [DefaultExecutionOrder(-1)]//Primero se ejecuta lo que esta en negativo y dps lo positivo
    public class ThemeManager : MonoBehaviour
    {
        [SerializeField] private ThemeSO mainTheme;
        public static ThemeManager Instance;
        public void Awake(){
            Instance = this;
        }

        public ThemeSO GetMainTheme(){
            return mainTheme;
        }
    
    }   
}

