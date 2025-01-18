namespace PrjFactoryMethod_API.Factory
{
    public class OAuth : ILogin
    {
        public string Auth()
        {
            return "OAuth";
        }
    }
}
