/******************************************************************************/
/**
 * @file        CalibrationConsistency.cs
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

using ScriptAPI;

public class CalibrationConsistency : Script
{
    public override void Update()
    {
        if (LatencyCalibrator.Instance == null) return;

        var text = GetTextComponent();

        if (!LatencyCalibrator.Instance.IsDone)
        {
            text.SetVisible(false);
            return;
        }

        string rating  = LatencyCalibrator.Instance.GetConsistencyRating();
        float stdDev   = LatencyCalibrator.Instance.GetStdDevMs();
        bool retry     = LatencyCalibrator.Instance.ShouldRetry();

        string msg = $"Consistency: {rating}  (±{stdDev:F0} ms)";
        if (retry)
            msg += "   —   Results are inconsistent. Consider retrying.";

        text.SetText(msg);
        text.SetVisible(true);
    }
}
