using ExileCore.Shared;
using InputHumanizer.Input;

namespace InputHumanizerLib
{
    public class InputHumanizerDelegates
    {
        public delegate bool TryGetInputControllerDelegate(string requestingPlugin, out IInputController controller);
        public delegate SyncTask<IInputController> GetInputControllerDelegate(string requestingPlugin, TimeSpan waitTime);
    }
}
