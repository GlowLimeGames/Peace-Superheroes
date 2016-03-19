using UnityEngine;
using NodeEditorFramework;
using NodeEditorFramework.Utilities;

[Node(false, "Standard/Example/Dialoge Node")]
public class DialogeNode : Node
{
    public const string ID = "dialogeNode";
    public override string GetID { get { return ID; } }

    public string dialoge = "Message";

    public override Node Create(Vector2 pos)
    {
        DialogeNode node = CreateInstance<DialogeNode>();

        node.rect = new Rect(pos.x, pos.y, 150, 60);
        node.name = "Dialoge Node";

        node.CreateInput("Value", "Float");
        node.CreateOutput("Output val", "Float");

        return node;
    }

    protected internal override void NodeGUI()
    {
        GUILayout.Label("This is a custom Node!");

        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();

        Inputs[0].DisplayLayout();

        GUILayout.EndVertical();

        dialoge = GUILayout.TextArea(dialoge, 300);

        GUILayout.BeginVertical();

        Outputs[0].DisplayLayout();

        GUILayout.EndVertical();
        GUILayout.EndHorizontal();

    }

    public override bool Calculate()
    {
        if (!allInputsReady())
            return false;
        Outputs[0].SetValue<float>(Inputs[0].GetValue<float>() * 5);
        return true;
    }
}
