namespace Au.DI
{
    public class Container
    {
        public Container(Container parent)
        {
            this.parent = parent;
        }

        public readonly Container parent;

        public Container CreateChild()
        {
            return new Container(this);
        }

        public void Register<T>()
        {

        }
    }
}