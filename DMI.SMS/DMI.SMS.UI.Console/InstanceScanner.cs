using StructureMap;

namespace DMI.SMS.UI.Console
{
    internal class InstanceScanner : Registry
    {
        public InstanceScanner()
        {
            Scan(_ =>
            {
                // No the implementation of the interface is not in this assembly
                //_.TheCallingAssembly();

                // The implementation of the interface is in another assembly in the base directory
                _.AssembliesAndExecutablesFromApplicationBaseDirectory();

                // Default Convention is that the interface has the same name as the implementation except for the I prefix
                _.WithDefaultConventions();
            });
        }
    }
}
