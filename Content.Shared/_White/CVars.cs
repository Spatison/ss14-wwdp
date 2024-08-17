using Robust.Shared.Configuration;

namespace Content.Shared._White;

[CVarDefs]
public sealed class WhiteCVars
{
    #region TTS

    /// <summary>
    /// if the TTS system enabled or not.
    /// </summary>
    public static readonly CVarDef<bool> TtsEnabled = CVarDef.Create("tts.enabled", true, CVar.SERVERONLY);

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TtsApiUrl = CVarDef.Create("tts.api_url", "", CVar.SERVERONLY);

    /// <summary>
    /// The volume of TTS playback.
    /// </summary>
    public static readonly CVarDef<float> TtsVolume = CVarDef.Create("tts.volume", 0f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// TTS Cache.
    /// </summary>
    public static readonly CVarDef<int> TtsMaxCacheSize =
        CVarDef.Create("tts.max_cash_size", 200, CVar.SERVERONLY | CVar.ARCHIVE);

    #endregion

    #region Aspects

    public static readonly CVarDef<bool> IsAspectsEnabled =
        CVarDef.Create("aspects.enabled", false, CVar.SERVERONLY);

    public static readonly CVarDef<double> AspectChance =
        CVarDef.Create("aspects.chance", 0.1d, CVar.SERVERONLY);

    #endregion
}
