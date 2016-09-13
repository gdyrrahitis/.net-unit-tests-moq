namespace WorkingWithInterfaceCasting
{
    public class Implementor
    {
        private readonly IParentInterface _parent;

        public Implementor(IParentInterface parent)
        {
            _parent = parent;
        }

        public void DoWork()
        {
            // Do work with parent interface method
            _parent.ParentWork();

            // Do work with child interface method
            ((IChildInterface)_parent).ChildWork();
        }
    }
}
