using UnityEditor;
using UnityEngine;
using TMPro;

namespace Poke.UI
{
    public static class LayoutEditorUtil
    {
        [MenuItem("GameObject/UI/Layout/Layout", false, 9)]
        public static void CreateLayoutObject(MenuCommand command) {
            GameObject g = new GameObject("Layout");
            GameObjectUtility.SetParentAndAlign(g, command.context as GameObject);
            
            g.AddComponent<RectTransform>();
            g.AddComponent<Layout>();
            
            Undo.RegisterCreatedObjectUndo(g, "Create " + g.name);
            Selection.activeObject = g;
        }
        
        [MenuItem("GameObject/UI/Layout/Layout Text", false, 10)]
        public static void CreateLayoutTextObject(MenuCommand command) {
            GameObject g = new GameObject("LayoutText");
            GameObjectUtility.SetParentAndAlign(g, command.context as GameObject);
            
            g.AddComponent<RectTransform>();
            g.AddComponent<TextMeshProUGUI>().text = "New Text";
            g.AddComponent<LayoutText>();
            
            Undo.RegisterCreatedObjectUndo(g, "Create " + g.name);
            Selection.activeObject = g;
        }
        
        [MenuItem("GameObject/UI/Layout/Layout Item", false, 11)]
        public static void CreateLayoutItemObject(MenuCommand command) {
            GameObject g = new GameObject("LayoutItem");
            GameObjectUtility.SetParentAndAlign(g, command.context as GameObject);
            
            g.AddComponent<RectTransform>();
            g.AddComponent<LayoutItem>();
            
            Undo.RegisterCreatedObjectUndo(g, "Create " + g.name);
            Selection.activeObject = g;
        }
        
        [MenuItem("GameObject/UI/Layout/Layout Root", false, 12)]
        public static void CreateLayoutRootObject(MenuCommand command) {
            GameObject g = new GameObject("LayoutRoot");
            GameObjectUtility.SetParentAndAlign(g, command.context as GameObject);
            
            g.AddComponent<RectTransform>();
            g.AddComponent<LayoutRoot>();
            
            Undo.RegisterCreatedObjectUndo(g, "Create " + g.name);
            Selection.activeObject = g;
        }
    }
}