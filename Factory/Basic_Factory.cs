namespace PrjFactoryMethod_API.Factory
{
    public class Basic_Factory : IAuthfactory
    {
      public ILogin Authentication()
        {
            return new Basic_Auth();
        }
    }
}
