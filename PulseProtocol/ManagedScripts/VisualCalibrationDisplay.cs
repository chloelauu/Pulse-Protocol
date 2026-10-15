/******************************************************************************/
/**
 * @file        VisualCalibrationDisplay.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using ScriptAPI;

// Mirrors CalibrationDisplay but for the visual latency calibrator.
// Attach to a TextComponent entity in the VisualLatencyCalibration scene.
public class VisualCalibrationDisplay : Script
{
    public override void Update()
    {
        if (VisualLatencyCalibrator.Instance == null) return;

        var text = GetTextComponent();

        if (VisualLatencyCalibrator.Instance.IsDone)
        {
            text.SetText($"Saved!   Display offset: {VisualLatencyCalibrator.Instance.GetOffsetMs():F0} ms");
            text.SetVisible(true);
        }
        else if (VisualLatencyCalibrator.Instance.IsAdjusting)
        {
            text.SetText(VisualLatencyCalibrator.Instance.GetOffsetLabel());
            text.SetVisible(true);
        }
        else
        {
            text.SetVisible(false);
        }
    }
}
