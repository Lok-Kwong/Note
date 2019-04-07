namespace Note.Attributes
{
    [Author("Manu Puduvalli", Version = 1.0)]
    [System.AttributeUsage(System.AttributeTargets.Class        |
                           System.AttributeTargets.Struct       |
                           System.AttributeTargets.Method       |
                           System.AttributeTargets.Interface    |
                           System.AttributeTargets.Enum)]
    internal class Beta : System.Attribute{}
}
