namespace FLexTools.Tools
{
    public class GUID
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
