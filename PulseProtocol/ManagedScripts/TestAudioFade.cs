/******************************************************************************/
/**
 * @file        TestAudioFade.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using System;
using ScriptAPI;

public class TestFadeKey : Script
{
    private bool triggered = false;

    public override void Update()
    {
        InputComponent input = GetInput();

        // F key
        if (!triggered && input.IsKeyTriggered(70))
        {
            triggered = true;
            Console.WriteLine("F pressed -> FadeOutMusic(2.0)");
            GetAudio().FadeOutMusic(2.0f);
        }
    }
}