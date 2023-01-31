namespace UsuariosAPI.Models
{
    public class Token
    {
        public int Value { get; }

        public Token(string value)
        {
            Value = value;
        }
    }
}
