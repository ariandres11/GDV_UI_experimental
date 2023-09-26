using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GDV_UI
{
    [CreateAssetMenu(menuName = "CustomUI/TextSO", fileName = "Text")]
    public class TextSO : ScriptableObject
    {
        public TMP_FontAsset font;
        public float size;
    }

}
