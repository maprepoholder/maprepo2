using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class LayoutSettings
	{
		[SerializeField]
		public string propDiffuse;
		[SerializeField]
		public string propNormal;
		[SerializeField]
		public string propOcclusion;
		[SerializeField]
		public string propDisplacement;
		[SerializeField]
		public string propSpecular;
		[SerializeField]
		public CompressionType rgbCompType;
		[SerializeField]
		public CompressionType alphaCompType;
		[SerializeField]
		public CompressionType normalCompType;
		[SerializeField]
		public CompressionType occlusionCompType;
		[SerializeField]
		public CompressionType displacementCompType;
		[SerializeField]
		public CompressionType specularCompType;
		[SerializeField]
		public int rgbQuality;
		[SerializeField]
		public int alphaQuality;
		[SerializeField]
		public int normalQuality;
		[SerializeField]
		public int occlusionQuality;
		[SerializeField]
		public int displacementQuality;
		[SerializeField]
		public int specularQuality;
		[SerializeField]
		public bool useAlpha;
		[SerializeField]
		public bool useNormal;
		[SerializeField]
		public bool useOcclusion;
		[SerializeField]
		public bool useDisplacement;
		[SerializeField]
		public bool useSpecular;
		[SerializeField]
		public bool editUseAlpha;
		[SerializeField]
		public bool editUseNormal;
		[SerializeField]
		public bool editUseOcclusion;
		[SerializeField]
		public bool editUseDisplacement;
		[SerializeField]
		public bool editUseSpecular;
		[SerializeField]
		public Color defaultDiffuseValue;
		[SerializeField]
		public Color defaultNormalValue;
		[SerializeField]
		public Color defaultOcclusionValue;
		[SerializeField]
		public Color defaultDisplacementValue;
		[SerializeField]
		public Color defaultSpecularValue;
	}
}
