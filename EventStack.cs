namespace Spellcast
{
    public class EventStack<TType>
    {
        private List<Func<TType, TType>> mods = new List<Func<TType, TType>>();

        //Run before the stack is applied to value
        public event Action<TType> onPreRunStack;

        //Run after the stack is applied to value
        public event Action<TType> onPostRunStack;

        public TType RunStack(TType value)
        {
            onPreRunStack?.Invoke(value);

            foreach (var e in mods)
            {
                value = e.Invoke(value);
            }

            onPostRunStack?.Invoke(value);

            return value;
        }

        public void RegisterMod(Func<TType, TType> mod)
        {
            mods.Add(mod);
        }

        public void UnregisterMod(Func<TType, TType> mod)
        {
            mods.Remove(mod);
        }
    }

    public class EventStack<TType, T1>
    {
        private List<Func<TType, T1, TType>> mods = new List<Func<TType, T1, TType>>();

        //Run before the stack is applied to value
        public event Action<TType, T1> onPreRunStack;

        //Run after the stack is applied to value
        public event Action<TType, T1> onPostRunStack;

        public TType RunStack(TType value, T1 t1)
        {
            onPreRunStack?.Invoke(value, t1);

            foreach (var e in mods)
            {
                value = e.Invoke(value, t1);
            }
            onPostRunStack?.Invoke(value, t1);

            return value;
        }

        public void RegisterMod(Func<TType, T1, TType> mod)
        {
            mods.Add(mod);
        }

        public void UnregisterMod(Func<TType, T1, TType> mod)
        {
            mods.Remove(mod);
        }

    }

    public class EventStack<TType, T1, T2>
    {
        private List<Func<TType, T1, T2, TType>> mods = new List<Func<TType, T1, T2, TType>>();

        //Run before the stack is applied to value
        public event Action<TType, T1, T2> onPreRunStack;

        //Run after the stack is applied to value
        public event Action<TType, T1, T2> onPostRunStack;

        public TType RunStack(TType value, T1 t1, T2 t2)
        {
            onPreRunStack?.Invoke(value, t1, t2);

            foreach (var e in mods)
            {
                value = e.Invoke(value, t1, t2);
            }
            onPostRunStack?.Invoke(value, t1, t2);

            return value;
        }

        public void RegisterMod(Func<TType, T1, T2, TType> mod)
        {
            mods.Add(mod);
        }

        public void UnregisterMod(Func<TType, T1, T2, TType> mod)
        {
            mods.Remove(mod);
        }
    }

    public class EventStack<TType, T1, T2, T3>
    {
        private List<Func<TType, T1, T2, T3, TType>> mods = new List<Func<TType, T1, T2, T3, TType>>();

        //Run before the stack is applied to value
        public event Action<TType, T1, T2, T3> onPreRunStack;

        //Run after the stack is applied to value
        public event Action<TType, T1, T2, T3> onPostRunStack;

        public TType RunStack(TType value, T1 t1, T2 t2, T3 t3)
        {
            onPreRunStack?.Invoke(value, t1, t2, t3);

            foreach (var e in mods)
            {
                value = e.Invoke(value, t1, t2, t3);
            }
            onPostRunStack?.Invoke(value, t1, t2, t3);

            return value;
        }

        public void RegisterMod(Func<TType, T1, T2, T3, TType> mod)
        {
            mods.Add(mod);
        }

        public void UnregisterMod(Func<TType, T1, T2, T3, TType> mod)
        {
            mods.Remove(mod);
        }
    }
}
