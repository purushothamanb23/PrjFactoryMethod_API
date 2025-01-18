namespace PrjFactoryMethod_API.Factory
{
    public class Auth_Factory
    {
        public static IAuthfactory CreateFactory(string type)
        {
            if (type == "Basic")
            {
                return new Basic_Factory();
            }
            else if (type == "Oauth")
            {
                return new OAuth_Factory();
            }
            else
            {
                return null;
            }

        }
    }
}
