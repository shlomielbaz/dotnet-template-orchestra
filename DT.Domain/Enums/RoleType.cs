using System.ComponentModel;

namespace DT.Domain.Enums
{
    public enum RoleType
    {
        [Description("Anonymous")]
        Anonymous = 1,
        [Description("User")]
        User = 2,
        [Description("Content Manager")]
        Editor = 3,
        [Description("Admin")]
        Admin = 4,
        [Description("Super")]
        Super = 5,
    }
}
