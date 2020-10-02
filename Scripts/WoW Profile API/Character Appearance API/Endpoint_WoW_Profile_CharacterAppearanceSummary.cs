// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

using System;
using System.Collections;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		/// <summary>
		/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
		/// </summary>
		public static partial class WowProfile
		{
			internal const string apiPath_CharacterAppearanceSummary = "/appearance";

			/// <summary>
			/// Coroutine that retrieves a summary of a character's appearance settings.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAppearanceSummary(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterAppearanceSummary> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + apiPath_CharacterAppearanceSummary;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a summary of a character's appearance settings, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAppearanceSummaryRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + apiPath_CharacterAppearanceSummary;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a summary of a character's appearance settings.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterAppearanceSummary : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public CharacterStruct character;
		public RefNameIdStruct playable_race;
		public RefNameIdStruct playable_class;
		public RefNameIdStruct active_spec;
		public TypeNameStruct gender;
		public TypeNameStruct faction;

		[Serializable]
		public struct GuildCrestItemColor
		{
			public int id;
			public ColorStruct rgba;
		}

		[Serializable]
		public struct GuildCrestItem
		{
			public int id;
			public RefIdStruct media;
			public GuildCrestItemColor color;
		}

		[Serializable]
		public struct GuildCrest
		{
			public GuildCrestItem emblem;
			public GuildCrestItem border;
			public GuildCrestItem background;
		}
		public GuildCrest guild_crest;

		[Serializable]
		public struct CharacterAppearance
		{
			public int face_variation;
			public int skin_color;
			public int hair_variation;
			public int hair_color;
			public int feature_variation;
			public int[] custom_display_options;
		}
		public CharacterAppearance appearance;

		[Serializable]
		public struct ItemAppearance
		{
			public int id;
			public TypeNameStruct slot;
			public int enchant;
			public int item_appearance_modifier_id;
			public int internal_slot_id;
			public int[] subclass;
		}
		public ItemAppearance[] items;
		// {{JSON_END}}
	}
}