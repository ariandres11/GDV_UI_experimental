using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



namespace GDV_UI
{
    public class Text : MonoBehaviour
    {
        public TextSO textData;
        public Style style;

        private TextMeshProUGUI textMeshProUGUI;

        private void Setup(){
            textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        }

        /*private void Configure (){
            ThemeSO theme = GetMainTheme();
            if( theme == null) return;
            //El color va a referenciar a style que contiene los colores definidos por le tema
            textMeshProUGUI.color = theme.GetTextColor(style);
            textMeshProUGUI.font = textData.font;
            textMeshProUGUI.fontSize = textData.size;

        }*/
        
        public void SetText(string text){
            textMeshProUGUI.text = text;
        }

    }
}


