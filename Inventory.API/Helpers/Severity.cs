using System.Runtime.Serialization;

namespace Inventory.API.Helpers
{
    [DataContract]
    public enum Severity
    {
        Error = 0,
        Info = 1,
        Warning = 2
    }
}
