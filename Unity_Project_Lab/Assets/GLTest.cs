using UnityEngine;
using System.Collections;

public class GLTest : MonoBehaviour {

    public static Material lineMaterial;
    public Material mMaterial;
    public RenderTexture tex;
    static void CreateLineMaterial()
    {
        if (!lineMaterial)
        {
            lineMaterial = new Material("Shader \"Lines/Colored Blended\"              " +
                                        "{                                             " +
                                        "    SubShader                                 " +
                                        "    {    Pass                                 " +
                                        "         {                                    " +
                                        "             Blend                            " +
                                        "             SrcAlpha                         " +
                                        "             OneMinusSrcAlpha                 " +
                                        "             ZWrite Off                       " +
                                        "             Cull Off                         " +
                                        "             Fog                              " +
                                        "             {                                " +
                                        "                 Mode Off                     " +
                                        "             }                                " +
                                        "             BindChannels                     " +
                                        "             {                                " +
                                        "                 Bind \"vertex\",             " +
                                        "                 vertex Bind \"color\", color " +
                                        "             }                                " +
                                        "         }                                    " +
                                        "    }                                         " +
                                        "}                                             ");
            lineMaterial.hideFlags = HideFlags.HideAndDontSave;
            lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
        }
       
    }
    void OnPostRender()
    {
        //CreateLineMaterial();

        //lineMaterial.SetPass(0);
        // GL.LineWidth(1.0f); // Command NOT FOUND
        //GetComponent<Renderer>().material = mMaterial;
        //int count = mMaterial.passCount;
        mMaterial.SetPass(4);
        GL.Begin(GL.TRIANGLES);
        GL.LoadOrtho();
        GL.Begin(GL.QUADS);
        GL.TexCoord(new Vector3(0, 0, 0));
        GL.Vertex3(0.25F, 0.25F, 0);
        GL.TexCoord(new Vector3(0, 1, 0));
        GL.Vertex3(0.25F, 0.75F, 0);
        GL.TexCoord(new Vector3(1, 1, 0));
        GL.Vertex3(0.75F, 0.75F, 0);
        GL.TexCoord(new Vector3(1, 0, 0));
        GL.Vertex3(0.75F, 0.25F, 0);

        GL.End();
    }
}
