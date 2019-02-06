using UnityEngine;
using System.Collections.Generic;
using AmplifyTexture;

public class AmplifyTextureManagerBase : MonoBehaviour
{
	[SerializeField]
	private List<VirtualTextureBase> m_virtualTextures;
	[SerializeField]
	private List<Camera> m_targetCameras;
	[SerializeField]
	private LayerMask m_cullingMask;
	[SerializeField]
	private MultiGPU m_multiGPU;
	[SerializeField]
	private EditorRuntimeProperties m_editorRuntime;
	public Texture2D m_emptyPageTable;
	public TextAsset m_dummyAsset;
}
