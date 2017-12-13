namespace Strategy
{
    public class Animal
    {
        protected IFlyable _flyType;

        public string GetFlyType()
        {
            return _flyType.Fly();
        }

        public void SetFlyType(IFlyable flyType)
        {
            _flyType = flyType;
        }
    }
}
