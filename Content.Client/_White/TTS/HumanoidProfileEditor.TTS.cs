﻿using System.Linq;
using Content.Client._White.TTS;
using Content.Shared.Preferences;
using Content.Shared._White.TTS;
using Content.Client.Lobby;
using Robust.Shared.Random;

// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Content.Client.Preferences.UI;

public sealed partial class HumanoidProfileEditor
{
    private TTSSystem _ttsSystem = default!;
    private TTSManager _ttsManager = default!;
    private IRobustRandom _random = default!;

    private List<TTSVoicePrototype> _voiceList = default!;

    private readonly string[] _sampleText =
    [
        "Помогите, клоун насилует в технических тоннелях!",
        "ХоС, ваши сотрудники украли у меня собаку и засунули ее в стиральную машину!",
        "Агент синдиката украл пиво из бара и взорвался!",
        "Врача! Позовите врача!"
    ];

    private const string AnySexVoiceProto = "SponsorAnySexVoices";

    private void InitializeVoice()
    {
        _random = IoCManager.Resolve<IRobustRandom>();
        _ttsManager = IoCManager.Resolve<TTSManager>();
        _ttsSystem = _entityManager.System<TTSSystem>();
        _voiceList = _prototypeManager.EnumeratePrototypes<TTSVoicePrototype>().Where(o => o.RoundStart).ToList();

        _voiceButton.OnItemSelected += args =>
        {
            _voiceButton.SelectId(args.Id);
            SetVoice(_voiceList[args.Id].ID);
        };

        _voicePlayButton.OnPressed += _ => { PlayTTS(); };
    }

    private void UpdateTTSVoicesControls()
    {
        if (Profile is null)
            return;

        // TODO: Sponsors manager
        // var sponsorsManager = IoCManager.Resolve<SponsorsManager>();

        _voiceButton.Clear();

        var firstVoiceChoiceId = 1;
        for (var i = 0; i < _voiceList.Count; i++)
        {
            var voice = _voiceList[i];
            if (!HumanoidCharacterProfile.CanHaveVoice(voice, Profile.Sex))
            {
                // TODO: Sponsors manager
                // if (!sponsorsManager.TryGetInfo(out var sponsorInfo)
                //     || !sponsorInfo.AllowedMarkings.Contains(AnySexVoiceProto))
                continue;
            }

            var name = Loc.GetString(voice.Name);
            _voiceButton.AddItem(name, i);

            if (firstVoiceChoiceId == 1)
                firstVoiceChoiceId = i;

            // TODO: Sponsors manager
            // if (voice.SponsorOnly &&
            //     sponsorsManager.TryGetInfo(out var sponsor) &&
            //     !sponsor.AllowedMarkings.Contains(voice.ID))
            // {
            //     _voiceButton.SetItemDisabled(i, true);
            // }
        }

        var voiceChoiceId = _voiceList.FindIndex(x => x.ID == Profile.Voice);
        if (!_voiceButton.TrySelectId(voiceChoiceId) &&
            _voiceButton.TrySelectId(firstVoiceChoiceId))
        {
            SetVoice(_voiceList[firstVoiceChoiceId].ID);
        }
    }

    private void PlayTTS()
    {
        var dummy = _controller.GetPreviewDummy();
        if (!dummy.HasValue || Profile is null)
            return;

        _ttsSystem.StopCurrentTTS(dummy.Value);
        _ttsManager.RequestTTS(dummy.Value, _random.Pick(_sampleText), Profile.Voice);
    }
}
