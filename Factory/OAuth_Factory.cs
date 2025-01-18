namespace PrjFactoryMethod_API.Factory
{
    public class OAuth_Factory : IAuthfactory
    {
        public ILogin Authentication()
        {
            return new OAuth();
        }
    }
}
