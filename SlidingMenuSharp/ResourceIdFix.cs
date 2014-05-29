using System;
using System.Linq;
using System.Reflection;
using Android.Runtime;

namespace SlidingMenuSharp
{
    public static class ResourceIdManager
    {
        static bool _idInitialized;

        public static void UpdateIdValues()
        {
            if (_idInitialized)
                return;
            var eass = Assembly.GetExecutingAssembly();
            Func<Assembly, Type> f = ass =>
                ass.GetCustomAttributes(typeof(ResourceDesignerAttribute), true).OfType<ResourceDesignerAttribute>().Where(ca => ca.IsApplication).Select(ca => ass.GetType(ca.FullName)).FirstOrDefault(ty => ty != null);
            var t = f(eass) ?? AppDomain.CurrentDomain.GetAssemblies().Select(ass => f(ass)).FirstOrDefault(ty => ty != null);
            if (t != null)
                t.GetMethod("UpdateIdValues").Invoke(null, new object[0]);
            _idInitialized = true;
        }
    }
}