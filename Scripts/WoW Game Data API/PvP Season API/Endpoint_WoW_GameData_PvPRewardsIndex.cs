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
		/// API endpoints related to World of Warcraft game data (items, spells, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/game-data-apis
		/// </summary>
		public static partial class WowGameData
		{
			internal const string apiPath_PvPRewardsIndex = BASEPATH_WOW_GAMEDATA + "/pvp-season/{0}/pvp-reward/index";

			/// <summary>
			/// Coroutine that retrieves an index of PvP rewards for a PvP season.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPRewardsIndex(int pvpSeasonId, Action<Json_Wow_PvPRewardsIndex> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_PvPRewardsIndex, pvpSeasonId);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves an index of PvP rewards for a PvP season, as a raw JSON string.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPRewardsIndexRaw(int pvpSeasonId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_PvPRewardsIndex, pvpSeasonId);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing an index of PvP rewards.
	/// </summary>
	[Serializable]
	public class Json_Wow_PvPRewardsIndex : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public RefIdStruct season;

		[Serializable]
		public struct PvPReward
		{
			public IdTypeStruct bracket;
			public RefNameIdStruct achievement;
			public int rating_cutoff;
			public TypeNameStruct faction;
		}
		public PvPReward[] rewards;
		// {{JSON_END}}
	}
}