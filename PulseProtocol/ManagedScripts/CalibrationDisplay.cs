/******************************************************************************/
/**
 * @file        CalibrationDisplay.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using ScriptAPI;

public class CalibrationDisplay : Script
{
    public override void Update()
    {
        if (LatencyCalibrator.Instance == null) return;

        var text = GetTextComponent();

        bool isDone   = LatencyCalibrator.Instance.IsDone;
        int done      = LatencyCalibrator.Instance.GetSamplesDone();
        int needed    = LatencyCalibrator.Instance.GetSamplesNeeded();
        float resultMs = LatencyCalibrator.Instance.GetResultMs();

        if (isDone)
        {
            // Calibration finished! show result
            text.SetText($"Calibration complete!   Offset: {resultMs:F0} ms");
            text.SetVisible(true);
        }
        else if (done > 0)
        {
            // In progress::: show count + last reaction time
            float lastMs = LatencyCalibrator.Instance.GetLastSampleMs();
            text.SetText($"Sample {done} / {needed}   (last: {lastMs:F0} ms)");
            text.SetVisible(true);
        }
        else
        {
            text.SetVisible(false);
        }
    }
}
