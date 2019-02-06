using UnityEngine;
using System;
using System.Collections.Generic;

namespace RenderHeads.Media.AVProVideo
{
	public class MediaPlayer : MonoBehaviour
	{
		[Serializable]
		public class PlatformOptions
		{
			public bool overridePath;
			public MediaPlayer.FileLocation pathLocation;
			public string path;
		}

		[Serializable]
		public class OptionsWindows : PlatformOptions
		{
			public Windows.VideoApi videoApi;
			public bool useHardwareDecoding;
			public bool useUnityAudio;
			public bool forceAudioResample;
			public bool useTextureMips;
			public bool hintAlphaChannel;
			public bool useLowLatency;
			public string forceAudioOutputDeviceName;
			public List<string> preferredFilters;
			public bool enableAudio360;
			public Audio360ChannelMode audio360ChannelMode;
		}

		[Serializable]
		public class OptionsMacOSX : PlatformOptions
		{
			public string httpHeaderJson;
		}

		[Serializable]
		public class OptionsIOS : PlatformOptions
		{
			public bool useYpCbCr420Textures;
			public string httpHeaderJson;
		}

		[Serializable]
		public class OptionsTVOS : PlatformOptions
		{
			public bool useYpCbCr420Textures;
			public string httpHeaderJson;
		}

		[Serializable]
		public class OptionsAndroid : PlatformOptions
		{
			public Android.VideoApi videoApi;
			public bool useFastOesPath;
			public bool showPosterFrame;
			public bool enableAudio360;
			public Audio360ChannelMode audio360ChannelMode;
			public string httpHeaderJson;
			[SerializeField]
			public int fileOffset;
		}

		[Serializable]
		public class OptionsWindowsPhone : PlatformOptions
		{
			public bool useHardwareDecoding;
			public bool useUnityAudio;
			public bool forceAudioResample;
			public bool useTextureMips;
			public bool useLowLatency;
		}

		[Serializable]
		public class OptionsWindowsUWP : PlatformOptions
		{
			public bool useHardwareDecoding;
			public bool useUnityAudio;
			public bool forceAudioResample;
			public bool useTextureMips;
			public bool useLowLatency;
		}

		[Serializable]
		public class OptionsWebGL : PlatformOptions
		{
		}

		[Serializable]
		public class OptionsPS4 : PlatformOptions
		{
		}

		public enum FileLocation
		{
			AbsolutePathOrURL = 0,
			RelativeToProjectFolder = 1,
			RelativeToStreamingAssetsFolder = 2,
			RelativeToDataFolder = 3,
			RelativeToPeristentDataFolder = 4,
		}

		public FileLocation m_VideoLocation;
		public string m_VideoPath;
		public bool m_AutoOpen;
		public bool m_AutoStart;
		public bool m_Loop;
		public float m_Volume;
		[SerializeField]
		private float m_Balance;
		public bool m_Muted;
		[SerializeField]
		public float m_PlaybackRate;
		public bool m_Resample;
		public Resampler.ResampleMode m_ResampleMode;
		public int m_ResampleBufferSize;
		[SerializeField]
		private bool m_DebugGui;
		[SerializeField]
		private bool m_DebugGuiControls;
		[SerializeField]
		private bool m_Persistent;
		public StereoPacking m_StereoPacking;
		public AlphaPacking m_AlphaPacking;
		public bool m_DisplayDebugStereoColorTint;
		public FilterMode m_FilterMode;
		public TextureWrapMode m_WrapMode;
		public int m_AnisoLevel;
		[SerializeField]
		private bool m_LoadSubtitles;
		[SerializeField]
		private FileLocation m_SubtitleLocation;
		[SerializeField]
		private string m_SubtitlePath;
		[SerializeField]
		private Transform m_AudioHeadTransform;
		[SerializeField]
		private bool m_AudioFocusEnabled;
		[SerializeField]
		private Transform m_AudioFocusTransform;
		[SerializeField]
		private float m_AudioFocusWidthDegrees;
		[SerializeField]
		private float m_AudioFocusOffLevelDB;
		[SerializeField]
		private MediaPlayerEvent m_events;
		[SerializeField]
		private OptionsWindows _optionsWindows;
		[SerializeField]
		private OptionsMacOSX _optionsMacOSX;
		[SerializeField]
		private OptionsIOS _optionsIOS;
		[SerializeField]
		private OptionsTVOS _optionsTVOS;
		[SerializeField]
		private OptionsAndroid _optionsAndroid;
		[SerializeField]
		private OptionsWindowsPhone _optionsWindowsPhone;
		[SerializeField]
		private OptionsWindowsUWP _optionsWindowsUWP;
		[SerializeField]
		private OptionsWebGL _optionsWebGL;
		[SerializeField]
		private OptionsPS4 _optionsPS4;
	}
}
