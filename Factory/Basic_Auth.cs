namespace PrjFactoryMethod_API.Factory
{
    public class Basic_Auth : ILogin
    {
        public string Auth()
        {
            return "Basic Auth";
        }
    }
}
