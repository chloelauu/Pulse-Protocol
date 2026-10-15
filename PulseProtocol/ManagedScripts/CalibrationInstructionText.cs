/******************************************************************************/
/**
 * @file        CalibrationInstructionText.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using ScriptAPI;

// Hides the "Press ENTER to begin" prompt once calibration has started.
public class CalibrationInstructionText : Script
{
    public override void Update()
    {
        if (LatencyCalibrator.Instance == null) return;
        if (!LatencyCalibrator.Instance.IsCalibrating) return;

        GetTextComponent().SetVisible(false);
    }
}
