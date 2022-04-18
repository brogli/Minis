namespace Minis
{
    //
    // Custom control class for MIDI controls
    //
    public class MidiClockControl : UnityEngine.InputSystem.Controls.AxisControl
    {
        public MidiClockControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;

            // AxisControl parameters
            normalize = true;
            normalizeMax = 0.49803921568f;
        }

        // Calculate control number from offset
        public int clockNumber { get { return (int)stateOffsetRelativeToDeviceRoot; } }
    }
}
