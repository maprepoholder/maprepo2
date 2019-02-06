using System;
using UnityEngine;
using AmplifyTexture;
using System.Collections.Generic;

[Serializable]
public class VirtualTextureBase : ScriptableObject
{
	[SerializeField]
	private HardwareLevel m_hardwareLevel;
	[SerializeField]
	private VirtualSize m_virtualSize;
	[SerializeField]
	private MipFilter m_mipFilter;
	[SerializeField]
	private int m_uvCoordSet;
	[SerializeField]
	public LayoutPreset m_layoutPreset;
	[SerializeField]
	public LayoutSettings m_layoutSettings;
	[SerializeField]
	public HardwareLevel m_editHardwareLevel;
	[SerializeField]
	public VirtualSize m_editVirtualSize;
	[SerializeField]
	public MipFilter m_editMipFilter;
	[SerializeField]
	public int m_editUVCoordSet;
	[SerializeField]
	public LayoutPreset m_editLayoutPreset;
	[SerializeField]
	public LayoutSettings m_editLayoutSettings;
	[SerializeField]
	private byte[] m_signature;
	[SerializeField]
	private VersionInfo m_version;
	[SerializeField]
	private string m_hashName;
	[SerializeField]
	private int m_assetIndex;
	[SerializeField]
	private int m_tileSize;
	[SerializeField]
	private int m_halfTileSize;
	[SerializeField]
	private int m_doubleTileSize;
	[SerializeField]
	private int m_borderSize;
	[SerializeField]
	private int m_doubleBorderSize;
	[SerializeField]
	private int m_pageSize;
	[SerializeField]
	private int m_pageChannelLength;
	[SerializeField]
	private int m_physicalTableSize;
	[SerializeField]
	private int m_physicalTableArea;
	[SerializeField]
	private int m_pageBlockSize;
	[SerializeField]
	private int m_mipCount;
	[SerializeField]
	private int m_channelCount;
	[SerializeField]
	public int m_diffuseLayerIndex;
	[SerializeField]
	public int m_normalLayerIndex;
	[SerializeField]
	public int m_occlusionLayerIndex;
	[SerializeField]
	public int m_displacementLayerIndex;
	[SerializeField]
	public int m_specularLayerIndex;
	[SerializeField]
	public TextureLayer[] m_textureLayers;
	[SerializeField]
	public List<string> m_materialFolders;
	[SerializeField]
	private TexturePacker m_packer;
	[SerializeField]
	private TextureCollection m_collection;
	[SerializeField]
	public int m_compressedSizeKB;
	[SerializeField]
	public int m_uncompressedSizeKB;
	[SerializeField]
	public float m_areaUsePercentage;
	[SerializeField]
	public float m_borderWastePercentage;
	[SerializeField]
	public VirtualSize m_savedVirtualSize;
	[SerializeField]
	public int m_savedPageTableSize;
	[SerializeField]
	public Vector2 m_savedPageTableScale;
	[SerializeField]
	public Vector2 m_savedPageTableOffset;
	[SerializeField]
	private PageFile m_pageFile;
}
