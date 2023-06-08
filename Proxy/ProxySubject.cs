namespace Proxy
{
    public class ProxySubject : ISubject
    {
        private RealSubject _realSubject;

        public void DoAction()
        {
            GetRealSubject().DoAction();
        }
        protected RealSubject GetRealSubject()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            return _realSubject;
        }
    }
}
