using UnityEditor;

namespace OpenFracture
{
    [CustomEditor(typeof(UnfreezeFragment))]
    [CanEditMultipleObjects]
    public class UnfreezeFragmentEditor : Editor
    {
        // Empty editor required for custom property drawers to work properly
    }
}