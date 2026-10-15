/******************************************************************************/
/**
 * @file        VisualCalibrationInstructionText.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using ScriptAPI;

// Hides the "Press ENTER to begin" prompt once visual calibration has started.
// Mirrors CalibrationInstructionText for the visual calibration scene.
public class VisualCalibrationInstructionText : Script
{
    public override void Update()
    {
        if (VisualLatencyCalibrator.Instance == null) return;
        if (!VisualLatencyCalibrator.Instance.IsAdjusting) return;

        GetTextComponent().SetVisible(false);
    }
}
